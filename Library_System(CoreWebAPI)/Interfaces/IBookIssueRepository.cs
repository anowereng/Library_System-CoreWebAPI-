using Library_System_CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Interfaces
{
    public interface IBookIssueRepository
    {
        void BookIssue(IssueBook issueBook);
        Book GetBook(string barcode);
        Student GetStudent(int studentid);
        void SaveChanges();
    }
}
