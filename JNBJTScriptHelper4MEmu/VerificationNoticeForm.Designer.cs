namespace JNBJTScriptHelper4MEmu
{
    partial class VerificationNoticeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificationNoticeForm));
            this.textBox_MEmuDir = new Sunny.UI.UITextBox();
            this.label1 = new Sunny.UI.UILabel();
            this.button_BrowseMEmuDir = new Sunny.UI.UIButton();
            this.comboBox_Devices = new Sunny.UI.UIComboBox();
            this.label2 = new Sunny.UI.UILabel();
            this.textBox_TempCaptureDir = new Sunny.UI.UITextBox();
            this.label3 = new Sunny.UI.UILabel();
            this.button_Browse_TempCaptureDir = new Sunny.UI.UIButton();
            this.checkBox_NoticeTypeVoice = new Sunny.UI.UICheckBox();
            this.checkBox_WindowsMess = new Sunny.UI.UICheckBox();
            this.label_NoticeType = new Sunny.UI.UILabel();
            this.label4 = new Sunny.UI.UILabel();
            this.label_RuningTime = new Sunny.UI.UILabel();
            this.button_OK = new Sunny.UI.UIButton();
            this.button_Close = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.label_similarBit = new Sunny.UI.UITrackBar();
            this.label_similarData = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.label_CurrentSimBit = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiTrackBar_TimerInterval = new Sunny.UI.UITrackBar();
            this.label_TimerInterval = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Style = Sunny.UI.UIStyle.Custom;
            // 
            // textBox_MEmuDir
            // 
            this.textBox_MEmuDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_MEmuDir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.textBox_MEmuDir.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textBox_MEmuDir.Location = new System.Drawing.Point(155, 53);
            this.textBox_MEmuDir.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MEmuDir.Maximum = 2147483647D;
            this.textBox_MEmuDir.Minimum = -2147483648D;
            this.textBox_MEmuDir.Name = "textBox_MEmuDir";
            this.textBox_MEmuDir.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_MEmuDir.Radius = 0;
            this.textBox_MEmuDir.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBox_MEmuDir.Size = new System.Drawing.Size(230, 25);
            this.textBox_MEmuDir.Style = Sunny.UI.UIStyle.Custom;
            this.textBox_MEmuDir.TabIndex = 0;
            this.textBox_MEmuDir.Text = "D:\\Program Files\\Microvirt\\MEmu";
            this.textBox_MEmuDir.TextChanged += new System.EventHandler(this.textBox_MEmuDir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.Style = Sunny.UI.UIStyle.Custom;
            this.label1.TabIndex = 1;
            this.label1.Text = "模拟器/ADB目录:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_BrowseMEmuDir
            // 
            this.button_BrowseMEmuDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_BrowseMEmuDir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.button_BrowseMEmuDir.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button_BrowseMEmuDir.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.button_BrowseMEmuDir.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button_BrowseMEmuDir.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button_BrowseMEmuDir.Location = new System.Drawing.Point(382, 52);
            this.button_BrowseMEmuDir.Margin = new System.Windows.Forms.Padding(2);
            this.button_BrowseMEmuDir.Name = "button_BrowseMEmuDir";
            this.button_BrowseMEmuDir.Radius = 0;
            this.button_BrowseMEmuDir.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.button_BrowseMEmuDir.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.button_BrowseMEmuDir.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.button_BrowseMEmuDir.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.button_BrowseMEmuDir.Size = new System.Drawing.Size(36, 26);
            this.button_BrowseMEmuDir.Style = Sunny.UI.UIStyle.Custom;
            this.button_BrowseMEmuDir.TabIndex = 2;
            this.button_BrowseMEmuDir.Text = "...";
            this.button_BrowseMEmuDir.Click += new System.EventHandler(this.button_BrowseMEmuDir_Click);
            // 
            // comboBox_Devices
            // 
            this.comboBox_Devices.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboBox_Devices.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.comboBox_Devices.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboBox_Devices.FormattingEnabled = true;
            this.comboBox_Devices.Location = new System.Drawing.Point(155, 87);
            this.comboBox_Devices.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Devices.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboBox_Devices.Name = "comboBox_Devices";
            this.comboBox_Devices.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.comboBox_Devices.Radius = 0;
            this.comboBox_Devices.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.comboBox_Devices.Size = new System.Drawing.Size(263, 25);
            this.comboBox_Devices.Style = Sunny.UI.UIStyle.Custom;
            this.comboBox_Devices.TabIndex = 3;
            this.comboBox_Devices.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboBox_Devices.ButtonClick += new System.EventHandler(this.comboBox_Devices_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 21);
            this.label2.Style = Sunny.UI.UIStyle.Custom;
            this.label2.TabIndex = 1;
            this.label2.Text = "运行中的设备清单:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_TempCaptureDir
            // 
            this.textBox_TempCaptureDir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TempCaptureDir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.textBox_TempCaptureDir.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textBox_TempCaptureDir.Location = new System.Drawing.Point(155, 124);
            this.textBox_TempCaptureDir.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TempCaptureDir.Maximum = 2147483647D;
            this.textBox_TempCaptureDir.Minimum = -2147483648D;
            this.textBox_TempCaptureDir.Name = "textBox_TempCaptureDir";
            this.textBox_TempCaptureDir.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_TempCaptureDir.Radius = 0;
            this.textBox_TempCaptureDir.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.textBox_TempCaptureDir.Size = new System.Drawing.Size(230, 25);
            this.textBox_TempCaptureDir.Style = Sunny.UI.UIStyle.Custom;
            this.textBox_TempCaptureDir.TabIndex = 0;
            this.textBox_TempCaptureDir.Text = "D:\\Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(41, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.Style = Sunny.UI.UIStyle.Custom;
            this.label3.TabIndex = 1;
            this.label3.Text = "临时截图目录:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Browse_TempCaptureDir
            // 
            this.button_Browse_TempCaptureDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Browse_TempCaptureDir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.button_Browse_TempCaptureDir.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button_Browse_TempCaptureDir.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.button_Browse_TempCaptureDir.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button_Browse_TempCaptureDir.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button_Browse_TempCaptureDir.Location = new System.Drawing.Point(384, 123);
            this.button_Browse_TempCaptureDir.Margin = new System.Windows.Forms.Padding(2);
            this.button_Browse_TempCaptureDir.Name = "button_Browse_TempCaptureDir";
            this.button_Browse_TempCaptureDir.Radius = 0;
            this.button_Browse_TempCaptureDir.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.button_Browse_TempCaptureDir.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.button_Browse_TempCaptureDir.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.button_Browse_TempCaptureDir.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.button_Browse_TempCaptureDir.Size = new System.Drawing.Size(36, 26);
            this.button_Browse_TempCaptureDir.Style = Sunny.UI.UIStyle.Custom;
            this.button_Browse_TempCaptureDir.TabIndex = 2;
            this.button_Browse_TempCaptureDir.Text = "...";
            this.button_Browse_TempCaptureDir.Click += new System.EventHandler(this.button_Browse_TempCaptureDir_Click);
            // 
            // checkBox_NoticeTypeVoice
            // 
            this.checkBox_NoticeTypeVoice.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_NoticeTypeVoice.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.checkBox_NoticeTypeVoice.Checked = true;
            this.checkBox_NoticeTypeVoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_NoticeTypeVoice.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.checkBox_NoticeTypeVoice.Location = new System.Drawing.Point(155, 161);
            this.checkBox_NoticeTypeVoice.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_NoticeTypeVoice.Name = "checkBox_NoticeTypeVoice";
            this.checkBox_NoticeTypeVoice.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBox_NoticeTypeVoice.Size = new System.Drawing.Size(61, 25);
            this.checkBox_NoticeTypeVoice.Style = Sunny.UI.UIStyle.Custom;
            this.checkBox_NoticeTypeVoice.TabIndex = 4;
            this.checkBox_NoticeTypeVoice.Text = "声音";
            this.checkBox_NoticeTypeVoice.Click += new System.EventHandler(this.checkBox_NoticeType_Click);
            // 
            // checkBox_WindowsMess
            // 
            this.checkBox_WindowsMess.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_WindowsMess.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.checkBox_WindowsMess.Checked = true;
            this.checkBox_WindowsMess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_WindowsMess.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.checkBox_WindowsMess.Location = new System.Drawing.Point(277, 161);
            this.checkBox_WindowsMess.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_WindowsMess.Name = "checkBox_WindowsMess";
            this.checkBox_WindowsMess.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.checkBox_WindowsMess.Size = new System.Drawing.Size(93, 25);
            this.checkBox_WindowsMess.Style = Sunny.UI.UIStyle.Custom;
            this.checkBox_WindowsMess.TabIndex = 4;
            this.checkBox_WindowsMess.Text = "系统消息";
            this.checkBox_WindowsMess.Click += new System.EventHandler(this.checkBox_NoticeType_Click);
            // 
            // label_NoticeType
            // 
            this.label_NoticeType.AutoSize = true;
            this.label_NoticeType.BackColor = System.Drawing.Color.Transparent;
            this.label_NoticeType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_NoticeType.Location = new System.Drawing.Point(9, 161);
            this.label_NoticeType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NoticeType.Name = "label_NoticeType";
            this.label_NoticeType.Size = new System.Drawing.Size(142, 21);
            this.label_NoticeType.Style = Sunny.UI.UIStyle.Custom;
            this.label_NoticeType.TabIndex = 1;
            this.label_NoticeType.Text = "防机关术提醒方式:";
            this.label_NoticeType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(73, 264);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.Style = Sunny.UI.UIStyle.Custom;
            this.label4.TabIndex = 5;
            this.label4.Text = "运行时长:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_RuningTime
            // 
            this.label_RuningTime.AutoSize = true;
            this.label_RuningTime.BackColor = System.Drawing.Color.Transparent;
            this.label_RuningTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_RuningTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.label_RuningTime.Location = new System.Drawing.Point(153, 264);
            this.label_RuningTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_RuningTime.Name = "label_RuningTime";
            this.label_RuningTime.Size = new System.Drawing.Size(72, 21);
            this.label_RuningTime.Style = Sunny.UI.UIStyle.Custom;
            this.label_RuningTime.TabIndex = 5;
            this.label_RuningTime.Text = "00:00:00";
            this.label_RuningTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_OK
            // 
            this.button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.button_OK.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button_OK.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.button_OK.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button_OK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button_OK.Location = new System.Drawing.Point(101, 300);
            this.button_OK.Margin = new System.Windows.Forms.Padding(2);
            this.button_OK.Name = "button_OK";
            this.button_OK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.button_OK.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.button_OK.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.button_OK.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.button_OK.Size = new System.Drawing.Size(66, 28);
            this.button_OK.Style = Sunny.UI.UIStyle.Custom;
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "启动";
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Close
            // 
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.button_Close.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button_Close.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(76)))), ((int)(((byte)(66)))));
            this.button_Close.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(64)))), ((int)(((byte)(55)))));
            this.button_Close.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.button_Close.Location = new System.Drawing.Point(274, 300);
            this.button_Close.Margin = new System.Windows.Forms.Padding(2);
            this.button_Close.Name = "button_Close";
            this.button_Close.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.button_Close.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.button_Close.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.button_Close.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(47)))), ((int)(((byte)(35)))));
            this.button_Close.Size = new System.Drawing.Size(66, 28);
            this.button_Close.Style = Sunny.UI.UIStyle.Custom;
            this.button_Close.TabIndex = 6;
            this.button_Close.Text = "退出";
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(25, 194);
            this.uiLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(126, 21);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "相似度提醒阈值:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_similarBit
            // 
            this.label_similarBit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(177)))));
            this.label_similarBit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.label_similarBit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_similarBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.label_similarBit.Location = new System.Drawing.Point(155, 194);
            this.label_similarBit.Minimum = 60;
            this.label_similarBit.Name = "label_similarBit";
            this.label_similarBit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.label_similarBit.Size = new System.Drawing.Size(230, 21);
            this.label_similarBit.Style = Sunny.UI.UIStyle.Custom;
            this.label_similarBit.TabIndex = 7;
            this.label_similarBit.Text = "label5";
            this.label_similarBit.Value = 80;
            this.label_similarBit.ValueChanged += new System.EventHandler(this.label_similarBit_ValueChanged);
            // 
            // label_similarData
            // 
            this.label_similarData.AutoSize = true;
            this.label_similarData.BackColor = System.Drawing.Color.Transparent;
            this.label_similarData.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_similarData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.label_similarData.Location = new System.Drawing.Point(392, 194);
            this.label_similarData.Name = "label_similarData";
            this.label_similarData.Size = new System.Drawing.Size(28, 21);
            this.label_similarData.Style = Sunny.UI.UIStyle.Custom;
            this.label_similarData.TabIndex = 8;
            this.label_similarData.Text = "80";
            this.label_similarData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(260, 265);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(94, 21);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 5;
            this.uiLabel2.Text = "当前相似度:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_CurrentSimBit
            // 
            this.label_CurrentSimBit.AutoSize = true;
            this.label_CurrentSimBit.BackColor = System.Drawing.Color.Transparent;
            this.label_CurrentSimBit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_CurrentSimBit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.label_CurrentSimBit.Location = new System.Drawing.Point(356, 265);
            this.label_CurrentSimBit.Name = "label_CurrentSimBit";
            this.label_CurrentSimBit.Size = new System.Drawing.Size(64, 21);
            this.label_CurrentSimBit.Style = Sunny.UI.UIStyle.Custom;
            this.label_CurrentSimBit.TabIndex = 8;
            this.label_CurrentSimBit.Text = "00.00%";
            this.label_CurrentSimBit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(17, 227);
            this.uiLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(131, 21);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "截图轮询时长(秒:";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTrackBar_TimerInterval
            // 
            this.uiTrackBar_TimerInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(177)))));
            this.uiTrackBar_TimerInterval.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(206)))), ((int)(((byte)(177)))));
            this.uiTrackBar_TimerInterval.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTrackBar_TimerInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.uiTrackBar_TimerInterval.Location = new System.Drawing.Point(155, 229);
            this.uiTrackBar_TimerInterval.Maximum = 60;
            this.uiTrackBar_TimerInterval.Minimum = 3;
            this.uiTrackBar_TimerInterval.Name = "uiTrackBar_TimerInterval";
            this.uiTrackBar_TimerInterval.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.uiTrackBar_TimerInterval.Size = new System.Drawing.Size(230, 21);
            this.uiTrackBar_TimerInterval.Style = Sunny.UI.UIStyle.Custom;
            this.uiTrackBar_TimerInterval.TabIndex = 7;
            this.uiTrackBar_TimerInterval.Text = "label5";
            this.uiTrackBar_TimerInterval.Value = 20;
            this.uiTrackBar_TimerInterval.ValueChanged += new System.EventHandler(this.uiTrackBar_TimerInterval_ValueChanged);
            // 
            // label_TimerInterval
            // 
            this.label_TimerInterval.AutoSize = true;
            this.label_TimerInterval.BackColor = System.Drawing.Color.Transparent;
            this.label_TimerInterval.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label_TimerInterval.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.label_TimerInterval.Location = new System.Drawing.Point(391, 229);
            this.label_TimerInterval.Name = "label_TimerInterval";
            this.label_TimerInterval.Size = new System.Drawing.Size(28, 21);
            this.label_TimerInterval.Style = Sunny.UI.UIStyle.Custom;
            this.label_TimerInterval.TabIndex = 8;
            this.label_TimerInterval.Text = "20";
            this.label_TimerInterval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VerificationNoticeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(207)))), ((int)(((byte)(177)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(441, 344);
            this.Controls.Add(this.label_CurrentSimBit);
            this.Controls.Add(this.label_TimerInterval);
            this.Controls.Add(this.label_similarData);
            this.Controls.Add(this.uiTrackBar_TimerInterval);
            this.Controls.Add(this.label_similarBit);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_RuningTime);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_WindowsMess);
            this.Controls.Add(this.checkBox_NoticeTypeVoice);
            this.Controls.Add(this.comboBox_Devices);
            this.Controls.Add(this.button_Browse_TempCaptureDir);
            this.Controls.Add(this.button_BrowseMEmuDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.label_NoticeType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TempCaptureDir);
            this.Controls.Add(this.textBox_MEmuDir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "VerificationNoticeForm";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(45)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "江南百景图机关术验证监控程序(安卓平台)";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VerificationNoticeForm_FormClosed);
            this.Load += new System.EventHandler(this.VerificationNoticeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UITextBox textBox_MEmuDir;
        private Sunny.UI.UILabel label1;
        private Sunny.UI.UIButton button_BrowseMEmuDir;
        private Sunny.UI.UIComboBox comboBox_Devices;
        private Sunny.UI.UILabel label2;
        private Sunny.UI.UITextBox textBox_TempCaptureDir;
        private Sunny.UI.UILabel label3;
        private Sunny.UI.UIButton button_Browse_TempCaptureDir;
        private Sunny.UI.UICheckBox checkBox_NoticeTypeVoice;
        private Sunny.UI.UICheckBox checkBox_WindowsMess;
        private Sunny.UI.UILabel label_NoticeType;
        private Sunny.UI.UILabel label4;
        private Sunny.UI.UILabel label_RuningTime;
        private Sunny.UI.UIButton button_OK;
        private Sunny.UI.UIButton button_Close;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITrackBar  label_similarBit;
        private Sunny.UI.UILabel label_similarData;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel label_CurrentSimBit;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UITrackBar uiTrackBar_TimerInterval;
        private Sunny.UI.UILabel label_TimerInterval;
    }
}

