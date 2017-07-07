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
        CipherBlock cp; // se crea el objeto para cifrar
        DecipherBlock dp; // y para decifrar
        Random rn; // clase de generacion aleatoria, para generar claves aleatorias
        int lenghtBl = Cifrado_XOR.Properties.Settings.Default.LenghtBlock; /* obtenemos la configuracion de usuario *ver preferences.cs*/
        char modeCi = Cifrado_XOR.Properties.Settings.Default.Cipher_Mode; /**/
        string textC, textD, key; // creamos variables para almacenar texto cifrado, decifrado y la clave
        public main()
        {
            InitializeComponent();
            labelBlock.Text = String.Format("Tamaño de bloque: {0}", lenghtBl); //labels para saber el tamaño de bloques
            labelMod.Text = String.Format("Modo: {0}", (modeCi == 'S')? "Simple": "Doble"); //usamos el una expresion ? para escribir "Simple" o "Doble" 
        }

        private void preferenceMenu_Click(object sender, EventArgs e)
        {
            preferences options = new preferences(); /* funcion para abrir el menu de configuración*/
            options.Show();
        }

        private void exitApp_Click(object sender, EventArgs e) // funcion para preguntarle al usuario si quiere salir de la aplicacion
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

        private void CipherBtn_Click(object sender, EventArgs e) // funcion del evento onClick del boton cifrar 
        {
            textC = entryBoxTxt.Text;                           /*llenamos las variables con los datos de la caja de texto,*/
            key = keyBoxTxt.Text;                                
            cp = new CipherBlock(lenghtBl, modeCi, textC, key); /*e instanciamos la clase inicializando el constructor con los valores descritos antes*/
            resultBoxTxt.Text = cp.Cipher(); // se llama al metodo cipher encargado de cifrar *ver CipherBlock.cs*
        }

        private void DecipherBtn_Click(object sender, EventArgs e) // funcion del evento onClick del boton decifrar
        {
            textD = entryBoxTxt.Text;
            key = keyBoxTxt.Text;
            dp = new DecipherBlock(lenghtBl, modeCi, textD, key);// igual que en el metodo Cipher pero esta vez usamos el objeto DecipherBlock *ver DecipherBlock.cs* */
            resultBoxTxt.Text = dp.Decipher();
        }

        private void keyBoxTxt_TextChanged(object sender, EventArgs e) // con esta funcion delimitamos la cantidad de caracteres dependiendo el tamaño del bloque
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

        private void generateKey_Click(object sender, EventArgs e) // funcion para generar clave aleatoria
        {
            string key = "";
            rn = new Random();
            for (int i = 0; i < lenghtBl / 8; i++) { // nota: dividimos por ocho nuevamente para obtener el tamaño del bloque en bytes,
                key += rn.Next(0, 9);                //  que es proporcional a la cantidad de caracteres de la clave
            }
            keyBoxTxt.Text = key;
        }
    }
}
