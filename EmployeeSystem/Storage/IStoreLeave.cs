using System;
using System.Collections.Generic;
using EmployeeSystem.Models;  
namespace EmployeeSystem.Storage
{
    public interface IStoreLeave
    {
        void Mark(Leave newLeave);
        List<Leave> GetAll();
        string Approve(Guid leaveid,string leavestatus);
        Leave GetById(Guid leaveid);
        void Update(Leave updateLeave);
    }
}
