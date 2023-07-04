using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace TGuilit
{
    public partial class MiscCustomForm : UserControl
    {

        public static bool Bunny = false;
        public MiscCustomForm()
        {
            InitializeComponent();
        }


        private void MiscCustomForm_Load(object sender, EventArgs e)
        {

        }

        

        private void CB_Bunny_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Bunny.Checked)
            {
                Bunny = true;
            }
            else
            {
                Bunny = false;
            }
        }
    }
}
