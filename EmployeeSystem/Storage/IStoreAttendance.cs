using System;
using System.Collections.Generic;
using EmployeeSystem.Models;  
namespace EmployeeSystem.Storage
{
    public interface IStoreAttendance
    {
        void Mark(Attendance newAttendance);
        List<Attendance> GetAll();
        
    }
}
