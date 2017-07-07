using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_XOR
{
    class CipherBlock
    {
        Blocks B;
        private int block;
        private char mode;
        private string Text;
        private string Key;
        private string codeText;
        public CipherBlock(int BlockMode, char ModeCipher, string text, string key) {
            block = BlockMode;
            mode = ModeCipher;
            Text = text;
            Key = key;
            B = new Blocks(BlockMode, text);
        }
        public string Cipher() {
            byte[,] block = B.AddBlocks();
            int lenght_block1 = block.GetLength(0), lenght_block2 = block.GetLength(1);
            int blockTxt = lenght_block1 * lenght_block2, ij = 0;
            byte[] blockCipher = new byte[blockTxt];
            for (int i = 0; i < lenght_block1; i++) {
                for (int j = 0; j < lenght_block2; j++, ij++)
                {
                    blockCipher[ij] = Convert.ToByte(block[i,j] ^ (byte)Key[j]);
                }
            }
            for (int i = 0; i < blockCipher.Length; i++) {
                codeText += Convert.ToChar(blockCipher[i]).ToString();
            }
            return codeText;
        }

        
    }
}
