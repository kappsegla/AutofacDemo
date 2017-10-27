using AutofacDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo.DataAccess
{
    class DemoDataContext : DbContext
    {
        public DemoDataContext() :base("DemoDataContext")
        {

        }

        public virtual DbSet<Student> Students { get; set; }

    }
}
