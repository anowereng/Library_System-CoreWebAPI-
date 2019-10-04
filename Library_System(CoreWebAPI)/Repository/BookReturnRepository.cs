using Library_System_CoreWebAPI;
using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Repository
{
    public class BookReturnRepository : IBookReturnRepository
    {
        private LibrarySystemContext _context;
        public BookReturnRepository(LibrarySystemContext context) { _context = context; }

        public void BookReturn(ReturnBook returnBook)
        {
            _context.Add(returnBook);
        }

        public Book GetBook(string barcode)
        {
            return _context.Book.Where(x => x.Barcode == barcode).FirstOrDefault();
        }
        public Student GetStudent(int studentid)
        {
            return _context.Student.Find(studentid);

        }
        public IssueBook GetIssueInfoBook(string barcode)
        {
            return _context.IssueBook.Where(x => x.Barcode == barcode).FirstOrDefault();
        }
        public IssueBook GetIssueInfoStudent(int studentid)
        {
            return _context.IssueBook.Find(studentid);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
