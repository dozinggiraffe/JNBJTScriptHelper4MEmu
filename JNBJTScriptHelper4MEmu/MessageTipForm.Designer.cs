namespace JNBJTScriptHelper4MEmu
{
    partial class MessageTipForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageTipForm));
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Style = Sunny.UI.UIStyle.Custom;
            // 
            // MessageTipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(545, 321);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageTipForm";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.StyleCustomMode = true;
            this.Text = "糟糕!机关术被发现了⊙﹏⊙‖∣";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(55)))), ((int)(((byte)(47)))));
            this.VisibleChanged += new System.EventHandler(this.MessageTipForm_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion
    }
}