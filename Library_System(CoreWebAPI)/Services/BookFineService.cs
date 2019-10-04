using Library_System_CoreWebAPI.Models;
using Library_System_CoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Services
{
    public class BookFineService : IBookFineService
    {
        private IBookFineRepository _bookFineRepository;

        public BookFineService(IBookFineRepository bookFineRepository)
        {
            _bookFineRepository = bookFineRepository; 
        }
        public double GetFineAmount(int id)
        {
            var fineamount = _bookFineRepository.GetStudentForFineAmount(id).FineAmount;
            return fineamount;
        }

        public void ReceiveFineAmount(Student model)
        {
            var student = _bookFineRepository.GetStudentForFineAmount(model.Id);
            var recvAmount = model.FineAmount;
            var dueamount = (student.FineAmount - recvAmount);

            if (recvAmount > student.FineAmount)
                model.FineAmount = 0;
            else
            student.FineAmount = dueamount;

            _bookFineRepository.SaveChanges();
        }
    }
}
