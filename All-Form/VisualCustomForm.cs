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
    public partial class VisualCustomForm : UserControl
    {
        public VisualCustomForm()
        {
            InitializeComponent();
        }

        public static bool esp_line = false;
        public static bool recoil_cross = false;
        public static bool esp_2d = false;
        public static bool esp_3d = false;

        private void VisualCustomForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void CB_Line_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Line.Checked)
            {
                esp_line = true;
            }
            else
            {
                esp_line = false;
            }
        }

        private void CB_RecoilCrosshair_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_RecoilCrosshair.Checked)
            {
                recoil_cross = true;
            }
            else
            {
                recoil_cross = false;
            }
        }

        private void CB_2DESP_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_2DESP.Checked)
            {
                esp_2d = true;
            }
            else
            {
                esp_2d = false;
            }
        }

        private void CB_3DESP_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_3DESP.Checked)
            {
                esp_3d = true;
            }
            else
            {
                esp_3d = false;
            }
        }
    }
}

