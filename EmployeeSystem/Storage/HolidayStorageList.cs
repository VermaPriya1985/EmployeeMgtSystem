using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeSystem.Models;
namespace EmployeeSystem.Storage
{
    public class HolidayStorageList : IStoreHoliday
    {
        private readonly List<Holiday> _holidayList;
        
        // Constructor
        public HolidayStorageList()
        {
            _holidayList = new List<Holiday>();
        }

        // Methods
        public void Create(Holiday newHoliday)
        {
            _holidayList.Add(newHoliday);
        }
        
         public void Update(Holiday updateHoliday) 
         {
            var holiday = GetById(updateHoliday.HolidayId);
            holiday.FromDate = updateHoliday.FromDate;
            holiday.ToDate = updateHoliday.ToDate;
            holiday.HolidayName = updateHoliday.HolidayName;
            holiday.Comments = updateHoliday.Comments;
        }
        
        public Holiday GetById(Guid id) 
        {
            var holiday = _holidayList.Find(x => x.HolidayId == id);

            if (holiday == null) 
            {
                throw new Exception($"Holiday {id} does not exist!!");
            }

            return holiday;
        }

        public List<Holiday> GetByName(string holidayname)
        {
            return _holidayList.Where(x => x.HolidayName.ToLower() == holidayname.ToLower()).ToList();
    
        }

        public List<Holiday> GetAll()
        {
            return _holidayList;
        }
    }
}


