using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TextEditor>();
            builder.RegisterType<SpellChecker>().As<ISpellChecker>();
            builder.RegisterType<CSharpSpellChecker>().As<ISpellChecker>().IfNotRegistered(typeof(ISpellChecker));

            var container = builder.Build();

            TextEditor textEditor = container.Resolve<TextEditor>();

            Console.Read();
      


        }
    }
}
