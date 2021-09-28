using FirstApi.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentDetailsAsync();
    }
}
