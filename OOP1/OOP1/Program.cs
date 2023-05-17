using System;

namespace OOP1
{    
    internal class Program
    {
        static void Main(string[] args)
        {
            ICypherer cypherer = null;
            string cypherType;                      
            while (cypherer == null)
            {
                Console.WriteLine("Caesar (1) or Vigenere(2)?");
                cypherType = Console.ReadLine();
                if (cypherType == "1")
                {
                    cypherer = new Caesar();
                }
                else if (cypherType == "2")
                {
                    string key;
                    Console.WriteLine("enter the key word");
                    key = Console.ReadLine();
                    cypherer = new Vigenere(key);
                }
            }
            Encoder encoder = new Encoder(cypherer);
            encoder.Encode();
        }
    }
}