using Library_System_CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Interfaces
{
    public interface IBookReturnRepository
    {
        void BookReturn(ReturnBook issueBook);
        Book GetBook(string barcode);
        Student GetStudent(int studentid);
        IssueBook GetIssueInfoStudent(int studntid);
        IssueBook GetIssueInfoBook(string barcode);
        //ReturnBook GetReturnInfoBook(string barcode);
        void SaveChanges();
    }
}
