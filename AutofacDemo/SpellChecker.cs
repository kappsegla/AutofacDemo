using System;

namespace AutofacDemo
{
    public class SpellChecker : ISpellChecker
    {
        public SpellChecker(string input)
        {
            Console.WriteLine("SpellChecker constructor");
        }

    }
}