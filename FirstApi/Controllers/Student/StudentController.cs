using FirstApi.DomainModel;
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
           _studentRepository = studentRepository;
        }
    
        [HttpGet]
        public IActionResult GetStudentDetails()
        {
            var students = _studentRepository.GetStudentDetails();
            var domainModelStudents = new List<DomainModel.Student>();
            foreach( var student in students)
            {
                domainModelStudents.Add(new DomainModel.Student()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Email = student.Email,
                    Mobile = student.Mobile,
                    ProfileImageUrl = student.ProfileImageUrl,
                    GenderId = student.GenderId,
                    Address = new Address()
                    {
                        Id = student.Address.Id,
                        PostalAddress = student.Address.PostalAddress,
                        PhysicalAddress = student.Address.PhysicalAddress,
                        StudentId = student.Address.StudentId
                    },
                    Gender = new Gender()
                    {
                        Id = student.Gender.Id,
                        Description = student.Gender.Description
                    },

                });
               
            }

            return Ok(domainModelStudents);
        }
    }
}
