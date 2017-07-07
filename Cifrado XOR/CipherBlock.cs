using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_XOR
{
    class CipherBlock
    {
        Blocks B; // creamos el objeto para separar en bloques *ver Blocks.cs*
        private int block; // bloque
        private char mode; // modo de cifrado (en desuso por el momento)
        private string Text; //texto en claro   
        private string Key; // clave de cifrado 
        private string codeText; // texto de salida
        public CipherBlock(int BlockMode, char ModeCipher, string text, string key) {
            block = BlockMode;
            mode = ModeCipher;
            Text = text;
            Key = key;
            B = new Blocks(BlockMode, text); /* inicializamos los valores del constructor e instanciamos, 
                                              *e invocamos el objeto Blocks para la separación en bloques*/
        }
        public string Cipher() {
            byte[,] block = B.AddBlocks();// el metodo addblock nos devuelve un array bidimesiones con el texto separado en bloques
            int lenght_block1 = block.GetLength(0), lenght_block2 = block.GetLength(1); // lenght_block1 = tamaño de primera dimension del array, lenght_block2 = tamaño de segunda dimension
            int blockTxt = lenght_block1 * lenght_block2, ij = 0;  // blockTxt es el tamaño total del texto, producto de la cantidad de bloques de la primera dimension por la cantidad de bloques de segunda dimension, ij es un contador que aumenta durante los dos ciclos for anidados * ver linea 31*                   
            byte[] blockCipher = new byte[blockTxt];// almacenara el texto cifrado antes de poder revelarlo
            for (int i = 0; i < lenght_block1; i++) { // for anidados en funcion del tamaño del array bidimensional
                for (int j = 0; j < lenght_block2; j++, ij++)
                {
                    blockCipher[ij] = Convert.ToByte(block[i,j] ^ (byte)Key[j]); // realizamos la operacion XOR entre la posicion del byte del array y la posicion del byte de la Clave
                }
            }
            for (int i = 0; i < blockCipher.Length; i++) {
                codeText += Convert.ToChar(blockCipher[i]).ToString(); // con este for colocamos en la variable de salida el texto en claro, convirtiendolo de bytes a caracteres
            }
            return codeText; //retornamos texto en claro
        }

        
    }
}
