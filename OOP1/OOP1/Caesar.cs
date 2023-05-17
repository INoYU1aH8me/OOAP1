using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Caesar: ICypherer
    {        
        public string DoCypher(string input)
        {
            string result = "";
            foreach (char letter in input)
            {
                char shift = 'a';
                if ((letter >= 'A') && (letter <= 'Z'))
                {
                    shift = 'A';
                }                
                result += (char)((letter + 1 - shift) % 26 + shift);
            }
            return result;
        }
    }
}
