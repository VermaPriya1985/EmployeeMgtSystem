using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeSystem.Models;
namespace EmployeeSystem.Storage
{
    public class ConcernStorageList : IStoreConcern
    {
        private readonly List<Concern> _concernList;
        // Constructor
        public ConcernStorageList()
        {
            _concernList = new List<Concern>();
        }

        // Methods
        public void Create(Concern newConcern)
        {
            _concernList.Add(newConcern);
        }
        
        public void Update(Concern updateConcern) 
        {
            var concern = GetById(updateConcern.ConcernId);
            concern.ConcernType = updateConcern.ConcernType;
            concern.ConcernRemarks = updateConcern.ConcernRemarks;
            concern.ConcernStatus = updateConcern.ConcernStatus;
            
        }
        
        public Concern GetById(Guid id) 
        {
            var concern = _concernList.Find(x => x.ConcernId == id);

            if (concern == null) 
            {
                throw new Exception($"Concern {id} does not exist!!");
            }

            return concern;
        }
        public List<Concern> GetByName(string concerntype)
        {
            return _concernList.Where(x => x.ConcernType.ToLower() == concerntype.ToLower()).ToList();
    
        }
        public List<Concern> GetAll()
        {
            return _concernList;
        }
    }
}


