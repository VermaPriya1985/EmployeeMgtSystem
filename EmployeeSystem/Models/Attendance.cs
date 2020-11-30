using System;
namespace EmployeeSystem.Models  
{
    public class Attendance
    {

        /*public Attendance(long attendanceid, long employeeid, 
        DateTime attendancedate,DateTime intime,DateTime outtime,int status)  
        {
            AttendanceId = attendanceid;
            EmployeeId = employeeid;
            AttendanceDate=attendancedate;
            InTime=intime;
            OutTime=outtime;
            Status=status;
        }
        
        // Data Members
        public long AttendanceId { get; }
        public long EmployeeId { get; }
        public DateTime AttendanceDate { get; private set; }
        public DateTime InTime { get; private set; }
        public DateTime OutTime { get; private set; }
        public int Status { get; private set; }
    */

        public long AttendanceId { get;set; }
        public long EmployeeId { get;set; }
        public DateTime AttendanceDate { get;  set; }
        public DateTime InTime { get;  set; }
        public DateTime OutTime { get;  set; }
        public int Status { get;  set; }
      
    }
}