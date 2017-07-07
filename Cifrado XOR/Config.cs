using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cifrado_XOR
{
    class Config
    {
        private int lenghtBlock;
        private char modeC;
        private int defaultBlock = 128;
        private char defaultMode = 'S';
        public Config() {
            lenghtBlock = defaultBlock;
            modeC = defaultMode;
        }
        public Config(int BlockLenght, char modeCipher)
        {
            lenghtBlock = BlockLenght;
            modeC = modeCipher;
        }
        public int lenght_block
        {
            get
            {
                return lenghtBlock;
            }
        }
        public char Mode_Cipher
        {
            get
            {
                return modeC;
            }
        }
    }
}
