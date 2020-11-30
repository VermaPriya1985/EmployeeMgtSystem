using System;
using System.Collections.Generic;
using EmployeeSystem.Models;  
namespace EmployeeSystem.Storage
{
    public interface IStoreHoliday
    {
        void Create(Holiday newHoliday);
        Holiday GetById(Guid holidayid);
        void Update(Holiday updateHoliday);
        List<Holiday> GetByName(string holidayname);
        List<Holiday> GetAll();
    }
}
