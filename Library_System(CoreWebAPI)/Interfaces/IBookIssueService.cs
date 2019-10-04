﻿using Library_System_CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Interfaces
{
    public interface IBookIssueService
    {
        void BookIssue(IssueBook issueBook);
        bool IsValidForBookIssue(IssueBook issueBook);
    }
}
