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
    public partial class main : Form
    {
        CipherBlock cp;
        DecipherBlock dp;
        int lenghtBl = Cifrado_XOR.Properties.Settings.Default.LenghtBlock;
        char modeCi = Cifrado_XOR.Properties.Settings.Default.Cipher_Mode;
        string textC, textD,key;
        public main()
        {
            InitializeComponent();
            labelBlock.Text = String.Format("Tamaño de bloque: {0}", lenghtBl);
            labelMod.Text = String.Format("Modo: {0}", (modeCi == 'S')? "Simple": "Doble");
        }

        private void preferenceMenu_Click(object sender, EventArgs e)
        {
            preferences options = new preferences();
            options.Show();
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            var box = MessageBox.Show("¿Esta seguro que quiere salir?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (box == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void CipherBtn_Click(object sender, EventArgs e)
        {
            textC = entryBoxTxt.Text;
            key = keyBoxTxt.Text;
            cp = new CipherBlock(lenghtBl, modeCi, textC, key);
            resultBoxTxt.Text = cp.Cipher();
        }

        private void DecipherBtn_Click(object sender, EventArgs e)
        {
            textD = entryBoxTxt.Text;
            key = keyBoxTxt.Text;
            dp = new DecipherBlock(lenghtBl, modeCi, textD, key);
            resultBoxTxt.Text = dp.Decipher();
        }

        private void keyBoxTxt_TextChanged(object sender, EventArgs e)
        {
            if (lenghtBl == 128) {
                keyBoxTxt.MaxLength = 16;
            }
            else if (lenghtBl == 192)
            {
                keyBoxTxt.MaxLength = 24;
            }
            else {
                keyBoxTxt.MaxLength = 32;
            }
        }
    }
}
