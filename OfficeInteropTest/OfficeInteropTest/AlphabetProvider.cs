using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeInteropTest
{
    public class AlphabetProvider
    {
        public IEnumerable<char> GetAlphabet()
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {
                yield return c;
            }
        }
    }
}
