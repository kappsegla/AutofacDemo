using System;

namespace AutofacDemo
{
    public class TextRow : ITextRow
    {
        public TextRow(string defaultText)
        {
            Console.WriteLine("TextRow constructor");
            text = defaultText;
        }
        public string text { get; set; }
    }
}