using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Services
{
    public class BookIssueService : IBookIssueService
    {
        private IBookIssueRepository _bookIssueRepository;

        public BookIssueService(IBookIssueRepository bookIssueRepository)
        {
            _bookIssueRepository = bookIssueRepository; 
        }

        public void BookIssue(IssueBook bookIssue)
        {
            /**validation check student and book**/
            if (IsValidForBookIssue(bookIssue))
            {
                bookIssue.BookId = _bookIssueRepository.GetBook(bookIssue.Barcode).Id;
                _bookIssueRepository.BookIssue(bookIssue);
                _bookIssueRepository.SaveChanges();
                 BookStockUpdate(bookIssue);
            }
               
        }

        /** validation check **/
        public bool IsValidForBookIssue(IssueBook bookIssue)
        {
            var book = _bookIssueRepository.GetBook(bookIssue.Barcode);
            var student = _bookIssueRepository.GetStudent(bookIssue.StudentId);
            var availableCopy = _bookIssueRepository.GetBook(bookIssue.Barcode).Copycount;

            if (book != null && student != null && availableCopy > 0)
                return true;
            else
                return false;
        }

        public void BookStockUpdate(IssueBook bookIssue)
        {
            var book = _bookIssueRepository.GetBook(bookIssue.Barcode);
            book.Copycount -= 1;
            _bookIssueRepository.SaveChanges();
        }

      
    }
}
