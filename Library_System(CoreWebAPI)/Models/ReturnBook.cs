﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library_System_CoreWebAPI.Models
{
    public class ReturnBook
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public Student Student { get; set; }
        public string Barcode { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
