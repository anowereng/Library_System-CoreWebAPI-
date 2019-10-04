using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository) { _bookRepository = bookRepository; }

        //public int AvailableCopy(string barcode)
        //{
        //    return _bookRepository.GetBook(barcode).Copycount;
        //}

        public void BookAdd(Book book)
        {
            _bookRepository.BookAdd(book);
        }

        //public bool IsValidBook(string barcode)
        //{
        //    var result = _bookRepository.GetBook(barcode)?.Barcode == barcode;
        //    return result;
        //}
    }
}
