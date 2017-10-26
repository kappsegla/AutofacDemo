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
        private Lazy<IStorage> _storage;
        private Func<string, ITextRow> _textRow;

        public TextEditor(ISpellChecker spellChecker, Lazy<IStorage> storage, Func<string, ITextRow> textRow)
        {
           _spellChecker = spellChecker;
           _storage = storage;
            _textRow = textRow;
        }

        public void M()
        {
            Console.WriteLine(_storage.Value.Uri.AbsolutePath);

            for(int i = 0; i < 3; i++)
            {
                var row = _textRow("Default text" + i);
                Console.WriteLine(row.text);
            }

        }
    }
}
