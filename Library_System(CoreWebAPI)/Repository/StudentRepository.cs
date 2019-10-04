using Library_System_CoreWebAPI;
using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private LibrarySystemContext _context;
        public StudentRepository(LibrarySystemContext context) { _context = context; }
        public void StudentAdd(Student model)
        {
            _context.Add(model);
            _context.SaveChanges();
        }
        public Student GetStudent(int StudentId)
        {
            var data = _context.Student.Where(x => x.Id == StudentId).FirstOrDefault();
            return data;
        }

    }
}
