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
        public DbSet<Tbl_Address> Tbl_Address { get; set; }

        public DbSet<Tbl_Gender> Tbl_Gender { get; set; }

        public DbSet<Tbl_Student> Tbl_Student { get; set; }

    }
}
