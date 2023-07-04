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
    public partial class AimCustomForm : UserControl
    {
        public AimCustomForm()
        {
            InitializeComponent();
        }

        private void AimCustomForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        public static bool Aimbot = false;
        public static bool trigger = false;
        private void CB_Aimbot_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Aimbot.Checked)
            {
                Aimbot = true;
            }
            else
            {
                Aimbot = false;
            }
        }

        private void CB_Trigger_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Trigger.Checked)
            {
                trigger = true;
            }
            else
            {
                trigger = false;                   
            }
        }
    }
}

