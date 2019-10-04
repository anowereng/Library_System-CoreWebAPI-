using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Services
{
    public class BookReturnService : IBookReturnService
    {
        private IBookReturnRepository _bookReturnRepository;

        public BookReturnService(IBookReturnRepository bookReturnRepository)
        {
            _bookReturnRepository = bookReturnRepository;
        }

        public void BookReturn(ReturnBook bookReturn)
        {

            if (IsValidBookStudentData(bookReturn) && IsValidIssueData(bookReturn))
            {
                bookReturn.BookId= _bookReturnRepository.GetBook(bookReturn.Barcode).Id;
                _bookReturnRepository.BookReturn(bookReturn);
                _bookReturnRepository.SaveChanges();
                 UpdateFineAmount(bookReturn); UpdateBookStock(bookReturn.Barcode);
            }
           
        }

        /** validation check **/
        public bool IsValidBookStudentData(ReturnBook bookReturn)
        {
            var book = _bookReturnRepository.GetBook(bookReturn.Barcode);
            var student = _bookReturnRepository.GetStudent(bookReturn.StudentId);
            var result = book != null || student != null ? true : false;
            return result;
        }

        public bool IsValidIssueData(ReturnBook bookReturn)
        {
            var issueInfoBybook = _bookReturnRepository.GetIssueInfoBook(bookReturn.Barcode);
            var issueInfoByStudent = _bookReturnRepository.GetIssueInfoStudent(bookReturn.StudentId);

            var result = issueInfoBybook != null || issueInfoByStudent != null ? true : false;
            return result;
        }


        public void UpdateFineAmount(ReturnBook bookReturn)
        {
            _bookReturnRepository.GetStudent(bookReturn.StudentId).FineAmount  =  GetFineAmount(bookReturn);
            _bookReturnRepository.SaveChanges();
        }

        public float GetFineAmount(ReturnBook model)
        {
            var issueDate = _bookReturnRepository.GetIssueInfoBook(model.Barcode).IssueDate;
            float fineAmount = 0;
            TimeSpan totalDays = (DateTime.Now - issueDate);
            var Days = 7;
            if (totalDays.Days > Days)
            {
                double delayTotalDays = totalDays.Days - Days;
                double fine = delayTotalDays * 10;
                //fineAmount = fineAmount > 7 || fineAmount > 10 ? delayTotalDays * 10 : delayTotalDays * 20;
                fineAmount = (float)fine;
            }
            return fineAmount;
        }

        public void UpdateBookStock(string barcode)
        {
            var bookStockQty = _bookReturnRepository.GetBook(barcode);
            bookStockQty.Copycount += 1;
            _bookReturnRepository.SaveChanges();
        }


    }
}
