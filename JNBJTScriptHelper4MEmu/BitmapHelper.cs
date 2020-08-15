using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNBJTScriptHelper4MEmu
{
    public static class BitmapHelper
    {
        /// <summary>
        /// 通过FileStream 来打开文件，这样就可以实现不锁定Image文件，到时可以让多用户同时访问Image文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Bitmap ReadImageFile(string path)
        {
            using (FileStream fs = File.OpenRead(path)) //OpenRead
            {
                int filelength = 0;
                filelength = (int)fs.Length; //获得文件长度 
                Byte[] image = new Byte[filelength]; //建立一个字节数组 
                fs.Read(image, 0, filelength); //按字节流读取 
                System.Drawing.Image result = System.Drawing.Image.FromStream(fs);
                Bitmap bit = new Bitmap(result);
                return bit;
            }
        }

        /// <summary>
        /// Crops an image according to a selection rectangel
        /// </summary>
        /// <param name="image">
        /// the image to be cropped
        /// </param>
        /// <param name="selection">
        /// the selection
        /// </param>
        /// <returns>
        /// cropped image
        /// </returns>
        public static Bitmap Crop(Bitmap sourceImage, Rectangle selection)
        {
            Bitmap newImage = new System.Drawing.Bitmap(selection.Width, selection.Height);
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(newImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.Clear(System.Drawing.Color.Transparent);
                g.DrawImage(sourceImage, new System.Drawing.Rectangle(0, 0, selection.Width, selection.Height), selection,
                    System.Drawing.GraphicsUnit.Pixel);
                sourceImage.Dispose();
                return newImage;
            }
        }

        public static float CaculateSimilar(Bitmap img1, Bitmap img2)
        {

            if (img1 == null || img2 == null)
                return -1;
            var thumbnaiImgl = ReduceSize(img1);
            var thumbnaiImg2 = ReduceSize(img2);
            int[] baseBit = GetHisogram(thumbnaiImgl);
            int[] matchBit = GetHisogram(thumbnaiImg2);
            float result = GetResult(baseBit, matchBit);
            return result;
        }

        private static Bitmap ReduceSize(Bitmap SourceImg, int width = 256, int height = 256)
        {
            Bitmap image = (Bitmap)SourceImg.GetThumbnailImage(width, height, () => { return false; }, IntPtr.Zero);
            return image;

        }

        private static int[] GetHisogram(Bitmap img)
        {
            BitmapData data = img.LockBits(new System.Drawing.Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int[] histogram = new int[256];
            unsafe
            {

                byte* ptr = (byte*)data.Scan0;

                int remain = data.Stride - data.Width * 3;

                for (int i = 0; i < histogram.Length; i++)

                    histogram[i] = 0;

                for (int i = 0; i < data.Height; i++)
                {
                    for (int j = 0; j < data.Width; j++)
                    {
                        int mean = ptr[0] + ptr[1] + ptr[2];
                        mean /= 3;
                        histogram[mean]++;
                        ptr += 3;

                    }
                    ptr += remain;

                }
            }
            img.UnlockBits(data);
            return histogram;
        }

        private static float GetAbs(int firstNum, int secondNum)
        {
            float abs = Math.Abs((float)firstNum - (float)secondNum);
            float result = Math.Max(firstNum, secondNum);
            if (result == 0)
                result = 1;

            return abs / result;
        }

        //最终计算结果
        private static float GetResult(int[] firstNum, int[] scondNum)
        {
            if (firstNum.Length != scondNum.Length)
            {
                return 0;

            }
            else
            {
                float result = 0;
                int j = firstNum.Length;
                for (int i = 0; i < j; i++)
                {

                    result += 1 - GetAbs(firstNum[i], scondNum[i]);
                    Console.WriteLine(i + "----" + result);

                }
                return result / j;

            }

        }
    }
}
