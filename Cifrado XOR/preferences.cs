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
        private char modeC;
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
        // Modo de cifrado
        private void ModXor_CheckedChanged(object sender, EventArgs e)
        {
            modeC = 'S';
        }

        private void ModXor2_CheckedChanged(object sender, EventArgs e)
        {
            modeC = 'D';
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Cipher_Mode = modeC; // seteamos configuracion
            Properties.Settings.Default.LenghtBlock = bitBlock;
            Properties.Settings.Default.Save(); // guardamos
            Application.Restart(); // reiniciamos aplicacion
        }
    }
}
