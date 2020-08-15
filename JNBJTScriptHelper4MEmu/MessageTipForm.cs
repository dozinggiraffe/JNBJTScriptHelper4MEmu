using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JNBJTScriptHelper4MEmu
{
    public partial class MessageTipForm : UIForm
    {
        public MessageTipForm()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void MessageTipForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Close();
        }
    }
}
