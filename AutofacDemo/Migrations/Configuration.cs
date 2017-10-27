namespace AutofacDemo.Migrations
{
    using AutofacDemo.Model;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AutofacDemo.DataAccess.DemoDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AutofacDemo.DataAccess.DemoDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            Model.Course course1 = new Model.Course { CourseName = "Windowsprogrammering" };
            Model.Course course2 = new Model.Course { CourseName = "JavaProgrammering" };

            context.Courses.AddOrUpdate(f => f.CourseName,
                course1, course2);

            Student student1 = new Student { Name = "Pelle", Courses = new List<Model.Course>()};
            student1.Courses.Add(course1);

            context.Students.AddOrUpdate(f => f.Name,
                student1,
                new Student { Name = "Arne" },
                new Student { Name = "Kalle" });




                


        }
    }
}
