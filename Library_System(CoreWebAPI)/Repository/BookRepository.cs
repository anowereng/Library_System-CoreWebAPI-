using Library_System_CoreWebAPI;
using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private LibrarySystemContext _context;
        public BookRepository(LibrarySystemContext context) { _context = context; }

        public void BookAdd(Book model)
        {
            _context.Add(model);
        }

        public Book GetBook(string barcode)
        {
            return _context.Book.Find(barcode);
        }
        public void SaveChange() { _context.SaveChanges(); }
    }
}
