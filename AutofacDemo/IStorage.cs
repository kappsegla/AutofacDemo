using System;

namespace AutofacDemo
{
    public interface IStorage
    {
        string Load();
        void Save(string text);
        Uri Uri { get; set; }
    }
}