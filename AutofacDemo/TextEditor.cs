using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo
{
    class TextEditor
    {
        private ISpellChecker _spellChecker;

        public TextEditor(ISpellChecker spellChecker)
        {
            this._spellChecker = spellChecker;

        }
    }
}
