using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.DataModel
{
    public class StudentAdminContext : DbContext
    {
        public  StudentAdminContext(DbContextOptions<StudentAdminContext> options):base(options)
        {

        }
        public DbSet<Address> Address { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Student> Student { get; set; }

    }
}
