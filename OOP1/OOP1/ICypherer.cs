using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    interface ICypherer
    {
        /// <summary>
        /// takes phrase and cyphers it
        /// </summary>
        /// <returns></returns>
        string DoCypher(string input);       
    }
}
