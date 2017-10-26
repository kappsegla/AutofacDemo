using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo
{
    class FileStorage : IStorage
    {
        public FileStorage()
        {
            Console.WriteLine("FileStorage constructor");
        }
        public string Load()
        {
            return "";
        }

        public void Save(string text)
        {
            
        }
    }
}
