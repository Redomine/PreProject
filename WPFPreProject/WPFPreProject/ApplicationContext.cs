using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace WPFPreProject
{
    class ApplicationContext : DbContext
    {
        public DbSet<building> buildings { get; set; }

        public ApplicationContext() : base("DefaultConnection") { }
    }
}
