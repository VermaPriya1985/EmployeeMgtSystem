using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EmployeeSystem.Models;
namespace EmployeeSystem.Storage
{
    public class HolidayStorageEF : IStoreHoliday
    {
        
        private ApplicationContext _context;
        // Constructor
        public HolidayStorageEF(ApplicationContext context)
        {
             _context = context;
        }

        // Methods
        public void Create(Holiday newHoliday)
        {
           var holidayModel = ConvertToDb(newHoliday);
           _context.Holiday.Add(holidayModel);
           _context.SaveChanges();
        }
        
         public void Update(Holiday holidayToUpdate) 
         {

             var holidayDb = ConvertToDb(holidayToUpdate);
            _context.Holiday.Update(holidayDb);
            _context.SaveChanges();
        }
        
        public Holiday GetById(Guid id) 
        {
           var holidayFromDb = _context.Holiday
                .AsNoTracking()
                .First(x => x.HolidayId == id);
                // .Where(x => x.IsDeleted == false)
                // .First(x => x.BookId == id);
            var holiday = ConvertFromDb(holidayFromDb);
            return holiday;
        }

        public List<Holiday> GetByName(string holidayname)
        {
            // return _holidayList.Where(x => x.HolidayName.ToLower() == holidayname.ToLower()).ToList();
            var _holidayList = new List<Holiday>();
            return _holidayList;
        } 

        public List<Holiday> GetAll()
        {
            List<Holiday> results = new List<Holiday>();
            var holidayFromDb = _context.Holiday
                .AsNoTracking()
                // .Where(x => x.IsDeleted == false)
                .ToList();

            foreach(var holiday in holidayFromDb) 
            {
                var nextHoliday = ConvertFromDb(holiday);
                results.Add(nextHoliday);
            }

            return results;
        }

        public static Holiday ConvertFromDb(EFModels.Holiday holidayFromDb) 
        {
            return new Holiday() 
            {
                HolidayId = holidayFromDb.HolidayId,
                FromDate = holidayFromDb.FromDate,
                ToDate = holidayFromDb.ToDate,
                HolidayName = holidayFromDb.HolidayName,
                Comments = holidayFromDb.Comments,
            };
        }

        public static EFModels.Holiday ConvertToDb(Holiday holiday)
         {
            return new EFModels.Holiday() 
            {
                HolidayId = holiday.HolidayId,
                FromDate = holiday.FromDate,
                ToDate = holiday.ToDate,
                HolidayName = holiday.HolidayName,
                Comments = holiday.Comments,
                    
            };
        }
    }
}


