using Library_System_CoreWebAPI;
using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Repository
{
    public class BookFineRepository : IBookFineRepository
    {
        private LibrarySystemContext _context;
        public BookFineRepository(LibrarySystemContext context) { _context = context; }

        public Student GetStudentForFineAmount(int studentid)
        {
            return _context.Student.Find(studentid);
        }

        public void ReceiveFineAmount(int amount)
        {
            _context.Add(amount);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
