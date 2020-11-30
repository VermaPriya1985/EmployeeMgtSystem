using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeSystem.Models;
namespace EmployeeSystem.Storage
{
    public class AttendanceStorageList : IStoreAttendance
    {
        private readonly List<Attendance> _attendanceList;
        
        // Constructor
        public AttendanceStorageList()
        {
            _attendanceList = new List<Attendance>();
        }

        // Methods
        public void Mark(Attendance newAttendance)
        {
            _attendanceList.Add(newAttendance);
        }
        public List<Attendance> GetAll()
        {
            return _attendanceList;
        }
    }
}


