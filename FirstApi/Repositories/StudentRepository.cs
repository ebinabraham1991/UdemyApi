using FirstApi.DataModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext _context;
        public StudentRepository(StudentAdminContext context)
        {
            this._context = context;
        }
        public List<Student> GetStudentDetails()
        {
            return this._context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToList();
        }
    }
}
