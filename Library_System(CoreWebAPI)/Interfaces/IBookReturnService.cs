using Library_System_CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Interfaces
{
    public interface IBookReturnService
    {
        void BookReturn(ReturnBook bookReturn);
        bool IsValidBookStudentData(ReturnBook bookReturn);
        bool IsValidIssueData(ReturnBook bookReturn);
        void UpdateFineAmount(ReturnBook bookReturn);
        float GetFineAmount(ReturnBook model);
        void UpdateBookStock(string barcode);


    }
}
