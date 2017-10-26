using System;

namespace AutofacDemo
{
    public class TextRow : ITextRow
    {
        public TextRow()
        {
            Console.WriteLine("TextRow constructor");
        }
        public string text { get; set; }
    }
}