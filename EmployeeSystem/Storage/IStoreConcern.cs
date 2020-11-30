using System;
using System.Collections.Generic;
using EmployeeSystem.Models;  
namespace EmployeeSystem.Storage
{
    public interface IStoreConcern
    {
        void Create(Concern newConcern);
        List<Concern> GetByName(string concerntype);
        List<Concern> GetAll();
        void Update(Concern updateConcern);
        Concern GetById(Guid concernid);
    }
}
