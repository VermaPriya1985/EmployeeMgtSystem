using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeSystem.Storage
{
    public class ConcernStorageEF : IStoreConcern
    {
        private ApplicationContext _context;
        // Constructor
        public ConcernStorageEF(ApplicationContext context)
        {
             _context = context;
        }

        // Methods
        public void Create(Concern newConcern)
        {
            var concernModel = ConvertToDb(newConcern);
           _context.Concern.Add(concernModel);
           _context.SaveChanges();
       
        }
        
        public void Update(Concern concernToUpdate) 
        {
              var concernDb = ConvertToDb(concernToUpdate);
            _context.Concern.Update(concernDb);
            _context.SaveChanges();
        }
        
        public Concern GetById(Guid id) 
        {
            var concernFromDb = _context.Concern
                .AsNoTracking()
                // .Include(x => x.Employee);
                .First(x => x.ConcernId == id);
                var concern = ConvertFromDb(concernFromDb);
                // EmployeeStorageEF.ConvertFromDb(concernFromDb.Employee);
                return concern;
        }

        public List<Concern> GetByName(string concerntype)
        {
            // return _concernList.Where(x => x.ConcernType.ToLower() == concerntype.ToLower()).ToList();
            var _concernList = new List<Concern>();  
            return _concernList;
        }

        public List<Concern> GetAll()
        {
            List<Concern> results = new List<Concern>();
            var concernFromDb = _context.Concern
                .AsNoTracking()
                // .Where(x => x.IsDeleted == false)
                .ToList();

            foreach(var concern in concernFromDb) 
            {
                var nextConcern = ConvertFromDb(concern);
                results.Add(nextConcern);
            }

            return results;
        }

        public static Concern ConvertFromDb(EFModels.Concern concernFromDb) 
        {
            /* return new Concern(
                concernFromDb.ConcernId,
                // EmployeeStorageEF.ConvertFromDb(concernFromDb.Employee),
                // concernFromDb.EmployeeId,
                concernFromDb.ConcernDate,
                concernFromDb.ConcernType,
                concernFromDb.ConcernRemarks,
                concernFromDb.ConcernStatus);
                */
                return new Concern() 
            {             
                ConcernId = concernFromDb.ConcernId,
                EmployeeId = concernFromDb.EmployeeId, 
                ConcernDate = concernFromDb.ConcernDate,
                ConcernType = concernFromDb.ConcernType,
                ConcernRemarks = concernFromDb.ConcernRemarks,
                ConcernStatus = concernFromDb.ConcernStatus
                

            };
            
        }

            
        public static EFModels.Concern ConvertToDb(Concern concern)
        {
            return new EFModels.Concern() 
            {
                ConcernId = concern.ConcernId,
                EmployeeId = concern.EmployeeId, 
                // mployeeId = concern.EmployeeId, 
                ConcernDate = concern.ConcernDate,
                ConcernType = concern.ConcernType,
                ConcernRemarks = concern.ConcernRemarks,
                ConcernStatus = concern.ConcernStatus
                    
            };
        }

        
    }
}


