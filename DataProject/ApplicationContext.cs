using DataProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProject
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
            : base("name=Task")
        {

        }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<UserModel> Users { get; set; }
        //public virtual DbSet<Film> Films { get; set; }
        //public virtual DbSet<UserModel> Users { get; set; }

    }
}
