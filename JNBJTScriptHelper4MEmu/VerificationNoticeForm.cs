using NAudio.Wave;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JNBJTScriptHelper4MEmu
{
    public partial class VerificationNoticeForm : UIForm
    {
        public VerificationNoticeForm()
        {
            InitializeComponent();
            this.btn.FillHoverColor = Color.FromArgb(198, 80, 66);

            comboBox_Devices.ItemForm.SetRectColor(Color.FromArgb(198, 80, 66));
            comboBox_Devices.dropForm.SetRectColor(Color.FromArgb(198, 80, 66));
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_BrowseMEmuDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择模拟器的安装路径(该路径含有adb.exe文件)";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                textBox_MEmuDir.Text = foldPath;
            }
        }

        private void comboBox_Devices_DropDown(object sender, EventArgs e)
        {
            if (!CheckMEmuDir())
                return;

            String cmddevices = "\"" + textBox_MEmuDir.Text + "\\adb.exe" + "\" devices";
            CMDHelper.RunCmdCommand(cmddevices, out var result);

            Regex regex = new Regex(@"attached[\s\S]+\s{1}device");
            if (!regex.IsMatch(result))
            {

                UIMessageTip.ShowError(comboBox_Devices, "当下无可用设备!");
                return;
            }
            comboBox_Devices.Items.Clear();
            var match = regex.Match(result);
            foreach (Group group in match.Groups)
            {
                String data = group.Value.Replace("device", "").Replace("attached", "").Trim();
                String[] itemsList = data.Split('\r');
                foreach (var s in itemsList)
                {
                    String ss = Regex.Replace(s, "\\s*","");
                    comboBox_Devices.Items.Add(ss);
                }
              
            }


            if (comboBox_Devices.Items.Count > 0)
                comboBox_Devices.SelectedIndex = 0;
        }

        public bool CheckMEmuDir()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(textBox_MEmuDir.Text);

            if (!directoryInfo.Exists)
            {
                UIMessageTip.ShowError(textBox_MEmuDir, "您选择的模拟器目录不存在!");
                return false;
            }

            if (!File.Exists(directoryInfo.FullName + "\\adb.exe"))
            {

                UIMessageTip.ShowError(textBox_MEmuDir, "请确认您选择的是模拟器的安装目录！该目录应含有adb.exe文件!!");
                return false;
            }

            return true;
        }

        private void button_Browse_TempCaptureDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "临时目录的安装路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                textBox_TempCaptureDir.Text = foldPath;
            }
        }
        System.Windows.Forms.Timer timerScreenShotAndAnalyse = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer countTimer = new System.Windows.Forms.Timer();
        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                if (button_OK.Text == "启动")
                {
                    if (!CheckMEmuDir())
                        return;

                    if (String.IsNullOrEmpty(comboBox_Devices.Text))
                    {

                        UIMessageTip.ShowError(comboBox_Devices, "您尚未选择模拟器设备");
                        return;
                    }

                    DirectoryInfo directoryInfo = new DirectoryInfo(textBox_TempCaptureDir.Text);

                    if (!directoryInfo.Exists)
                        directoryInfo.Create();

                    if (File.Exists(textBox_TempCaptureDir.Text + "\\screen_temp.png"))
                    {
                        try
                        {
                            File.Delete(textBox_TempCaptureDir.Text + "\\screen_temp.png");
                        }
                        catch { }
                    }

                    TimerScreenShotAndAnalyse_Tick(null, null);
                    timerScreenShotAndAnalyse.Interval = uiTrackBar_TimerInterval.Value * 1000;
                    timerScreenShotAndAnalyse.Tick += TimerScreenShotAndAnalyse_Tick;
                    timerScreenShotAndAnalyse.Start();
                    //uiTrackBar_TimerInterval.Enabled = false;

                    countTimer.Interval = 1000;
                    countTimer.Tick += CountTime_Tick;
                    countTimer.Start();

                    button_OK.Text = "停止";
                }
                else
                {
                    timerScreenShotAndAnalyse.Stop();
                    //uiTrackBar_TimerInterval.Enabled = true;
                    countTimer.Stop();
                    countTimeSec = 0;
                    label_RuningTime.Text = "00:00:00";
                    label_CurrentSimBit.Text = "00.00%";
                    stopNoticeMusic();

                    if (frmShowWarning != null && !frmShowWarning.IsDisposed && frmShowWarning.Visible == true)
                        frmShowWarning.Hide();

                    timerScreenShotAndAnalyse.Tick -= TimerScreenShotAndAnalyse_Tick;
                    button_OK.Text = "启动";
                }
            }
            catch (Exception err)
            {
                UIMessageDialog.ShowErrorDialog(this, "系统异常", err.Message);
            }
        }
        int countTimeSec = 0;
        private void CountTime_Tick(object sender, EventArgs e)
        {
            countTimeSec++;
            label_RuningTime.Text = GetTime(countTimeSec);
        }
        string GetTime(double time)
        {
            double h = Math.Floor(time / 3600f);
            double m = Math.Floor(time / 60f - h * 60f);
            double s = Math.Floor(time - m * 60f - h * 3600f);
            return h.ToString("00") + ":" + m.ToString("00") + ":" + s.ToString("00");
        }

        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        private void TimerScreenShotAndAnalyse_Tick(object sender, EventArgs e)
        {
            String adbPath = "\"" + textBox_MEmuDir.Text + "\\adb.exe" + "\"";
            String cmd1 = adbPath + " -s " + comboBox_Devices.Text + " shell /system/bin/screencap -p /sdcard/data/screen_temp.png ";
            CMDHelper.RunCmdCommand(cmd1, out var result1);

            if (result1.Contains("No such file or directory"))
            {
                String cmd1_5 = adbPath = "\"" + textBox_MEmuDir.Text + "\\adb.exe"+ "\"" +" shell mkdir /sdcard/data/";
                CMDHelper.RunCmdCommand(cmd1_5, out var result1_5);
                CMDHelper.RunCmdCommand(cmd1, out  result1);
            }

            String cmd2 = adbPath + " -s " + comboBox_Devices.Text + " pull /sdcard/data/screen_temp.png " + textBox_TempCaptureDir.Text;
            CMDHelper.RunCmdCommand(cmd2, out var result2);

            if (CheckVerficationCodeShown())
            {
                if (checkBox_NoticeTypeVoice.Checked)
                {
                    playNoticeMusic();
                }

                if (checkBox_WindowsMess.Checked)
                    ShowMessageTipForm();

            }
            else
            {
                stopNoticeMusic();
                frmShowWarning.Hide();
            }
        }

        void playNoticeMusic()
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(Application.StartupPath + @"\\warning.mp3");
                outputDevice.Init(audioFile);
            }

            if (outputDevice.PlaybackState != PlaybackState.Playing)
                outputDevice.Play();
        }

        void stopNoticeMusic()
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            outputDevice = null;
            audioFile = null;
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            if (audioFile != null)
                audioFile.Position = 0;

            outputDevice?.Play();
        }

        private bool CheckVerficationCodeShown()
        {
            try
            {
                //截图照片
                var bitmapScreenShot = BitmapHelper.ReadImageFile(textBox_TempCaptureDir.Text + "\\screen_temp.png");
                var partbitMap = JNBJTScriptHelper4MEmu.Properties.Resources.sample;

                float xBit = 0.01f, yBit = 0.01f, widthBit = 0.01f, heightBit = 0.01f;

                bool isPortrait = bitmapScreenShot.Height > bitmapScreenShot.Width;

                if (!isPortrait)//如果是横屏
                {
                    xBit = 0.257f;
                    widthBit = 0.492f;
                    yBit = 0.172f;
                    heightBit = 0.657f;
                }
                else
                {
                    xBit = 0.06805f;
                    widthBit = 0.866f;
                    yBit = 0.314f;
                    heightBit = 0.367f;
                }

                int newRegionX = (int)(bitmapScreenShot.Width * xBit);
                int newRegionW = (int)(bitmapScreenShot.Width * widthBit);

                int newRegionY = (int)(bitmapScreenShot.Height * yBit);
                int newRegionH = (int)(bitmapScreenShot.Height * heightBit);

                var bitmapScreenShotCodeRegion = (Bitmap)BitmapHelper.Crop(bitmapScreenShot, new Rectangle(newRegionX, newRegionY, newRegionW, newRegionH));
                var result = BitmapHelper.CaculateSimilar(bitmapScreenShotCodeRegion, partbitMap);

                label_CurrentSimBit.Text = Math.Round(result, 4) * 100 + "%";

                if (result > (float)((float)label_similarBit.Value / 100))
                    return true;

                return false;
            }
            catch
            {
                return false;
            }
        }

        MessageTipForm frmShowWarning = new MessageTipForm();
        public void ShowMessageTipForm()
        {
            if (frmShowWarning == null || frmShowWarning.IsDisposed)
                frmShowWarning = new MessageTipForm();

            Point p = new Point(Screen.PrimaryScreen.WorkingArea.Width - frmShowWarning.Width, Screen.PrimaryScreen.WorkingArea.Height);
            frmShowWarning.PointToScreen(p);
            frmShowWarning.Location = p;

            frmShowWarning.Show();
            for (int i = 0; i <= frmShowWarning.Height / 10 + 1; i++)
            {
                frmShowWarning.Location = new Point(p.X, p.Y - i * 10);
                Thread.Sleep(10);
                Application.DoEvents();
            }

        }

        private void VerificationNoticeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            outputDevice = null;
            audioFile = null;
        }

        private void label_similarBit_ValueChanged(object sender, EventArgs e)
        {
            label_similarData.Text = label_similarBit.Value.ToString();
        }


        private void uiTrackBar_TimerInterval_ValueChanged(object sender, EventArgs e)
        {
            label_TimerInterval.Text = uiTrackBar_TimerInterval.Value.ToString();
            timerScreenShotAndAnalyse.Interval = uiTrackBar_TimerInterval.Value * 1000;
        }

        //private void checkBox_NoticeTypeVoice_ValueChanged(object sender, bool value)
        //{

        //}

        private void checkBox_NoticeType_Click(object sender, EventArgs e)
        {
            UICheckBox checkBox = sender as UICheckBox;
            bool allUnchecked = !checkBox_NoticeTypeVoice.Checked && !checkBox_WindowsMess.Checked;
            if (allUnchecked)
            {
                UIMessageTip.ShowError(checkBox, "声音和系统消息至少选一项！");
                checkBox.Checked = true;
            }


        }
        String iniPath = Application.StartupPath + "\\data.ini";
        private void textBox_MEmuDir_TextChanged(object sender, EventArgs e)
        {
            IniUtility.WriteIni("UserData", "AdbPath", textBox_MEmuDir.Text, iniPath);
        }

        private void VerificationNoticeForm_Load(object sender, EventArgs e)
        {
            String adbPath = String.Empty;
            adbPath = IniUtility.ReadIni("UserData", "AdbPath", "", iniPath);
            if (!String.IsNullOrEmpty(adbPath))
                textBox_MEmuDir.Text = adbPath;
        }
    }
}
