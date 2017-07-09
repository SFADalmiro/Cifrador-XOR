using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_XOR
{
    class DecipherBlock
    {
        Blocks B; // creamos el objeto para separar en bloques *ver Blocks.cs*
        private int block; // bloque
        private string Text, Key, StringDecipher;//texto cifrado, clave, texto de salida = esta es parecida a BlockCipher(linea29, CipherBlock.cs) pero almacenara el texto en caracteres y no en bytes
        public DecipherBlock(int BlockMode, string text, string key) {
            block = BlockMode;
            Text = text;
            Key = key;
            B = new Blocks(BlockMode, text);/* inicializamos los valores del constructor e instanciamos, 
                                              *e invocamos el objeto Blocks para la separación en bloques*/
        }
        public string Decipher() {
            byte[,] block = B.AddBlocks(); // el metodo addblock nos devuelve un array bidimesiones con el texto separado en bloques
            int lenght_block1 = block.GetLength(0), lengh_block2 = block.GetLength(1); // las siguientes variables son las mismas que en CipherBlock.cs y cumplen la misma funcion
            int blockTxt = lenght_block1 * lengh_block2, ij = 0; 
            
            byte chars; // variable para almacenar temporalmente el resultado de la operacion
            for (int i = 0; i < lenght_block1; i++) {
                for (int j = 0; j < lengh_block2; j++, ij++)  // for anidados en funcion del tamaño del array bidimensional
                {
                    chars = Convert.ToByte(block[i, j] ^ (byte)Key[j]); // realizamos operacion XOR para obtener el caracter decifrado
                    StringDecipher += Convert.ToChar(chars); // convertimos a char para revelar texto en claro
                }
            }
            return StringDecipher; // devolver texto en claro
        }
    }
}
