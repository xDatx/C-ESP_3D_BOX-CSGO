using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGuilit
{
    public partial class SettingCustomForm : UserControl
    {
        public SettingCustomForm()
        {
            InitializeComponent();
        }
        public static bool RainbowT = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Rainbow.Checked)
            {
                RainbowT = true;
            }
            else
            {
                RainbowT = false;
            }
        }

        private void SettingCustomForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
