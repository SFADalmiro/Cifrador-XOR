using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_XOR
{
    class DecipherBlock
    {
        Blocks B;
        private int block;
        private char mode;
        private string Text, Key, codeText;
        public DecipherBlock(int BlockMode, char ModeCipher, string text, string key) {
            block = BlockMode;
            mode = ModeCipher;
            Text = text;
            Key = key;
            B = new Blocks(BlockMode, text);
        }
        public string Decipher() {
            byte[,] block = B.AddBlocks();
            int lenght_block1 = block.GetLength(0), lengh_block2 = block.GetLength(1);
            int blockTxt = lenght_block1 * lengh_block2, ij = 0;
            char[] StringDecipher = new char[blockTxt];
            byte chars;
            for (int i = 0; i < lenght_block1; i++) {
                for (int j = 0; j < lengh_block2; j++, ij++)
                {
                    chars = Convert.ToByte(block[i, j] ^ (byte)Key[j]);
                    StringDecipher[ij] = Convert.ToChar(chars);
                }
            }
            for (int i = 0; i < blockTxt; i++) {
                codeText += StringDecipher[i].ToString();
            }
            return codeText;
        }
    }
}
