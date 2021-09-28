using FirstApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Controllers.Student
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }
    
        [HttpGet]
        public IActionResult GetStudentDetails()
        {
            return Ok(this._studentRepository.GetStudentDetails());
        }
    }
}
