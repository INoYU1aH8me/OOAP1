using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Vigenere: ICypherer
    {
        string key;
        public Vigenere(string key)
        {
            this.key = key;
        }
        public string DoCypher(string input)
        { 
            string result = "";
            int k = 0;
            foreach (char letter in input)
            {
                result += (char)((letter + key[k % key.Length]) % 26 + 65);
                k++;
            }
            return result;
        }
    }
}
