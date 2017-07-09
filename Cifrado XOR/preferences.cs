using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifrado_XOR
{
    public partial class preferences : Form
    {
        private int bitBlock;
        public preferences()
        {
            InitializeComponent();
        }

        private void Val128bits_CheckedChanged(object sender, EventArgs e)
        {
            bitBlock = 128;
        }

        private void Val192bits_CheckedChanged(object sender, EventArgs e)
        {
            bitBlock = 192;
        }

        private void Val256bits_CheckedChanged(object sender, EventArgs e)
        {
            bitBlock = 256;
        }

        private void saveConfig_Click(object sender, EventArgs e)
        { 
            Properties.Settings.Default.LenghtBlock = bitBlock;// seteamos configuracion
            Properties.Settings.Default.Save(); // guardamos
            Application.Restart(); // reiniciamos aplicacion
        }
    }
}
