using FirstApi.DataModel;
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
        public List<Tbl_Student> GetStudentDetails()
        {
            return this._context.Tbl_Student.ToList();
        }
    }
}
