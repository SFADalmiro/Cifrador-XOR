using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_XOR
{
    class Blocks
    {
        private int Block;
        private string textIn;
        public Blocks(int block, string textin) {
            Block = block;
            textIn = textin;
        }
        public byte[,] AddBlocks() {
            return AddBlocks(Block, textIn);
        }
        public byte[,] AddBlocks(int lenghtBlock, string text) {

            string copy_text = text;
            int lenghtBits = lenghtBlock / 8, lenghtText = copy_text.Length, tmp = lenghtBits, i = 0, j = 0, jcount = 0;
            while (lenghtText % lenghtBits != 0) {
                copy_text += 0x02;
                lenghtText = copy_text.Length;
            }
            int countBlock = lenghtText / lenghtBits;
            byte[,] boxText = new byte[countBlock, lenghtBits];
                for (; j < tmp; j++, jcount++)
                {
                    if (tmp > lenghtText) break;
                    boxText[i,jcount] = Convert.ToByte(copy_text[j]);
                    if (j == tmp - 1) {
                        j = tmp - 1;
                        tmp += lenghtBits;
                        i++;
                        jcount = -1;
                    }
                }
            return boxText;
        }

    }
}
