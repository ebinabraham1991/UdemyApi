using FirstApi.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudentDetails();
    }
}
