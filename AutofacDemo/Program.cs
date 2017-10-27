using Autofac;
using AutofacDemo.DataAccess;
using AutofacDemo.Model;
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

            //            TextEditor textEditor = container.Resolve<TextEditor>();



            //ISpellChecker spellChecker = new SpellChecker();

            //ISpellChecker spellChecker2 = new SpellCheckerFactory().createSpellChecker();

            Program p = new Program();
            p.Database();

  //          textEditor.M();

            Console.Read();
        }

        public void Database()
        {
            using (var ctx = new DemoDataContext())
            {
                ctx.Database.Log = Logger;
                var students = ctx.Students.Where(f => f.Name == "Martin");


                foreach(Student s in students){
                    Console.WriteLine(s.Name);

                }
            }
        }

        public void Logger(string value)
        {
            Console.Write(value);
        }
       
    }
}


