using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Encoder
    {
        ICypherer cypherer;     
        public Encoder(ICypherer cypherer)
        {
            this.cypherer = cypherer;
        }
        public void Encode()
        {
            while (true)
            {
                Console.WriteLine("write phrase");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                string encodedPhrase = cypherer.DoCypher(input);
                Console.WriteLine(encodedPhrase);
            }
        }
    }
}
