namespace AutofacDemo.Migrations
{
    using AutofacDemo.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

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
            context.Students.AddOrUpdate(f => f.Name,
                new Student { Name= "Martin" },
                new Student { Name = "Arne" },
                new Student { Name = "Kalle" });
        }
    }
}
