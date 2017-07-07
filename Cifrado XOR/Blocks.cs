/*La cantidad de variables me obligo a referenciarlas a parte en el superior de este archivo
 * copy_text = almacenamos en una variable secundaria el texto
 * lenghtBits = divimos el tamaño del bloque por ocho para obtener su largo en bytes
 * lenghtText = largo del texto
 * tmp = variable temporal para lenghtBits
 * i, j, jcount = contadores para ciclos for
 * countBlocks = cantidad de bloques
 * boxTxt = array que almacena los bloques de bytes
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_XOR
{
    class Blocks
    {
        private int Block;// tamaño de bloque
        private string textIn; // texto a separar
        public Blocks(int block, string textin) {
            Block = block;
            textIn = textin; // inicializamos propiedades
        }
        public byte[,] AddBlocks() { // sobrecarga de addblocks(int x, string y)
            return AddBlocks(Block, textIn);
        }
        public byte[,] AddBlocks(int lenghtBlock, string text) { // funcion que recibe como parametro, tamaño del bloque, y texto

            string copy_text = text;
            int lenghtBits = lenghtBlock / 8, lenghtText = copy_text.Length, tmp = lenghtBits, i = 0, j = 0, jcount = 0;
            while (lenghtText % lenghtBits != 0) { // si el largo del texto no es multiple del tamaño del bloque, rellenamos
                copy_text += 0x01; //rellenamos con 0x01
                lenghtText = copy_text.Length;
            }
            int countBlock = lenghtText / lenghtBits; // la cantidad de bloques es el producto entre el largo del texto por el tamaño del bloque en bytes(lenghtBits)
            byte[,] boxText = new byte[countBlock, lenghtBits]; // bloque
                for (; j < tmp; j++, jcount++)// empezamos el ciclo, aumentando j y jcount
                {
                    if (tmp > lenghtText) break; // para que el ciclo no se haga infinito
                    boxText[i,jcount] = Convert.ToByte(copy_text[j]); // convertimos a byte y llenamos el boque
                    if (j == tmp - 1) { // si "j" se hace mayor a tmp -1(para que no se salga de rango) 
                        j = tmp - 1;  // ahora j pasa a valer tmp - 1 (por el rango también)
                        tmp += lenghtBits; // y vamos sumandole el tamaño de bloque en bits
                        i++; //aumentamos "i" lo que seria pasar al siguiente bloque
                        jcount = -1; // y reiniciamos jcount pero en -1 tmb para que no se salga de rango
                    }
                }
            return boxText;// retornamos el bloque
        }

    }
}
