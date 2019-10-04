using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_System_CoreWebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        //public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Edition { get; set; }
        public string Barcode { get; set; }
        public int Copycount { get; set; }

        //public int StudentId { get; set; }
        //public Student Student { get; set; }
        //public IList<IssueBook> BookIssues { get; set; }
        //public IList<ReturnBook> BookReturns { get; set; }

    }
}
