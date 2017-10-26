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
        private IStorage _storage;

        public TextEditor(ISpellChecker spellChecker, IStorage storage)
        {
           _spellChecker = spellChecker;
           _storage = storage;
        }
    }
}
