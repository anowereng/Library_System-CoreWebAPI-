using Library_System_CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System_CoreWebAPI.Interfaces
{
    public interface IBookFineService
    {
        double GetFineAmount(int id);
        void ReceiveFineAmount(Student model);
    }
}
