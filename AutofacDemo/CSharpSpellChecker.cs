using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo
{
    class CSharpSpellChecker : ISpellChecker
    {
        public CSharpSpellChecker()
        {
            Console.WriteLine("CSharpSpellChecker");
        }
    }
}
