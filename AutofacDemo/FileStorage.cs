using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo
{
    class FileStorage : IStorage
    {
        private Uri _uri;
        private List<string> _theMagicList;
        
        public FileStorage()
        {
            Console.WriteLine("FileStorage constructor");
            _theMagicList = new List<string>();
        }

        public Uri Uri { get => _uri; set { _uri = value; Console.WriteLine(value.AbsoluteUri); } }

        public IEnumerable<string> theMagicList{get => _theMagicList; set => _theMagicList = value.ToList();}

        public string Load()
        {
            return "";
        }

        public void Save(string text)
        {
            
        }
    }
}
