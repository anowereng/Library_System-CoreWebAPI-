using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository) { _studentRepository = studentRepository; }
        public void StudentAdd(Student student)
        {
            _studentRepository.StudentAdd(student);
        }

        //public bool IsValidStudent(string studentid)
        //{
        //   return _studentRepository.IsValidStudent(studentid);
        //    //throw new NotImplementedException();
        //}

        //public int GetStudentById(string studentid)
        //{
        //    return _studentRepository.GetStudentById(studentid);
        //}
    }
}
