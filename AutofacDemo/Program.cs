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
            //builder.RegisterType<FileStorage>().As<IStorage>();
            builder.Register(c => new FileStorage { Uri = new Uri("http://webapi.com") }).As<IStorage>();
            builder.RegisterType<TextRow>().As<ITextRow>();

            var container = builder.Build();

            TextEditor textEditor = container.Resolve<TextEditor>();



            //ISpellChecker spellChecker = new SpellChecker();

            //ISpellChecker spellChecker2 = new SpellCheckerFactory().createSpellChecker();


            textEditor.M();

            Console.Read();
      


        }
    }
}
