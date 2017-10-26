using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo
{
    class SpellCheckerFactory
    {
        public ISpellChecker createSpellChecker()
        {
            return new SpellChecker();
        }

        public ISpellChecker createSpellChecker(string input)
        {
            return new SpellChecker();
        }


    }
}
