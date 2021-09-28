using AutoMapper;
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
        private readonly IMapper _mapper;
        public StudentController(IStudentRepository studentRepository,IMapper mapper)
        {
           _studentRepository = studentRepository;
            _mapper = mapper;
        }
    
        [HttpGet]
        public async Task<IActionResult> GetStudentDetails()
        {
            var students = await _studentRepository.GetStudentDetailsAsync();
            var domainModelStudents = _mapper.Map<List<DomainModel.Student>>(students);
            //foreach( var student in students)
            //{
            //    domainModelStudents.Add(new DomainModel.Student()
            //    {
            //        Id = student.Id,
            //        FirstName = student.FirstName,
            //        LastName = student.LastName,
            //        Email = student.Email,
            //        Mobile = student.Mobile,
            //        ProfileImageUrl = student.ProfileImageUrl,
            //        GenderId = student.GenderId,
            //        Address = new Address()
            //        {
            //            Id = student.Address.Id,
            //            PostalAddress = student.Address.PostalAddress,
            //            PhysicalAddress = student.Address.PhysicalAddress,
            //            StudentId = student.Address.StudentId
            //        },
            //        Gender = new Gender()
            //        {
            //            Id = student.Gender.Id,
            //            Description = student.Gender.Description
            //        },

            //    });
               
            //}
           
            return Ok(domainModelStudents);
        }
    }
}
