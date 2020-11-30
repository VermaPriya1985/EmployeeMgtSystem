using System;
using System.Collections.Generic;
using EmployeeSystem.Storage;
using EmployeeSystem.Models;
namespace EmployeeSystem 
{
    public class EmployeeManagement 
    {
        
       public EmployeeManagement(IStoreEmployee employeeStorage,
       IStoreLeave leaveStorage,IStoreHoliday holidayStorage,
       IStoreAttendance attendanceStorage, IStoreConcern concernStorage)
       {
        
        // Init storage using Dependency Injection
        _employeeStorage = employeeStorage;
        _leaveStorage = leaveStorage;
        _holidayStorage = holidayStorage;
        _attendanceStorage = attendanceStorage;
        _concernStorage = concernStorage;

        // Create Sample Employee,LEave etc
        DateTime dateofbirth =  Convert.ToDateTime("12-01-1990");
        DateTime dateofjoining =  Convert.ToDateTime("12-01-1990");
        // _employeeStorage.Create(new Employee(1, "Priya","Verma","Female","P001","Retallack Street","S4S3B9","MSCIT","5 years","1234567890","priya@gmail.com",dateofbirth,dateofjoining,"Ludhiana","Web Developer","Temporary","Single",1));
        // _employeeStorage.Create(new Employee(2, "JIYA","Verma","Female","P001","Retallack Street","S4S3B9","MSCIT","5 years","1234567890","priya@gmail.com",dateofbirth,dateofjoining,"Ludhiana","Web Developer","Temporary","Single",1));

        var newemployee= new Employee()
            {
                EmployeeId=Guid.NewGuid(),
                FirstName="Priya",
                LastName="Verma",
                Gender="Female",
                EmployeeCode="P001",
                Address="Retallack Street",
                PostalCode="S4S3B9",
                Qualification="Masters",
                Experience="5 years",
                MobileNo="1234567890",
                Email="verpriya@gmail.com",
                DateOfBirth=dateofbirth,
                DateOfJoining=dateofjoining,
                BranchName="regina",
                Designation="Developer",
                EmploymentType="Permanent",
                MaritalStatus="Married",
                Status=1
            };

        _employeeStorage.Create(newemployee);
        

        
        DateTime fromdate =  Convert.ToDateTime("12-01-2020");
        DateTime todate =  Convert.ToDateTime("12-05-2010");
        // _leaveStorage.Mark(new Leave(1,1,fromdate,todate,"Sick Leave","Disapproved",1));
        // _leaveStorage.Mark(new Leave(2,2,fromdate,todate,"Urgent Leave","Disapproved",1));

        var newleave= new Leave()
            {
                LeaveId=Guid.NewGuid(),
                EmployeeId=1,
                FromDate=fromdate,
                ToDate=todate,
                LeaveType="Sick",
                Reason="Sick Leave",
                LeaveStatus="Pending"
                // Status=1
            };

        _leaveStorage.Mark(newleave);
          


        DateTime holidayfromdate =  Convert.ToDateTime("12-01-2020");
        DateTime holidaytodate =  Convert.ToDateTime("12-01-2020");
        // _holidayStorage.Create(new Holiday(1,holidayfromdate,holidaytodate,"Diwali","Diwali Holiday",1));

         var newholiday= new Holiday()
            {
                HolidayId=Guid.NewGuid(),
                FromDate=holidayfromdate,
                ToDate=holidaytodate,
                HolidayName="Diwali",
                Comments="Diwali Celebration"
                // Status=1
            };

        _holidayStorage.Create(newholiday);
          

        DateTime attendancedate =  Convert.ToDateTime("11-17-2020");
        DateTime intime =  Convert.ToDateTime("11-17-2020 9:00:00");
        DateTime outtime = Convert.ToDateTime("11-17-2020 5:00:00");
        
        // _attendanceStorage.Mark(new Attendance(1,1,attendancedate,intime,outtime,1));

        var newattendance= new Attendance()
            {
                AttendanceId=1,
                EmployeeId=1,
                AttendanceDate=attendancedate,
                InTime=intime,
                OutTime=outtime,
                Status=1
            };

        _attendanceStorage.Mark(newattendance);
         

        DateTime concerndate =  Convert.ToDateTime("12-01-2019");
        // _concernStorage.Create(new Concern(1,1,concerndate,"Suggestion","Remarkssss","Open",1));
        var newconcern= new Concern()
            {
                ConcernId=Guid.NewGuid(),
                EmployeeId=1,
                ConcernDate=concerndate,
                ConcernType="Suggestion",
                Remarks="Remarkssss",
                ConcernStatus="Open"
            };

        _concernStorage.Create(newconcern);
        

    }

        /*** STORAGE ***/ 
        private readonly IStoreEmployee _employeeStorage;
        private readonly IStoreLeave _leaveStorage;
        private readonly IStoreHoliday _holidayStorage;
        private readonly IStoreAttendance _attendanceStorage;
        private readonly IStoreConcern _concernStorage;

        /*** METHODS ***/
        public List<Employee> SearchForEmployee(string titleToSearch)
        {
            return _employeeStorage.GetByName(titleToSearch);
        }

        public List<Employee> GetAllEmployee()
        {
            return _employeeStorage.GetAll();      
        }

        public Employee GetByEmployeeId(Guid id) 
        {
            return _employeeStorage.GetById(id);
        }

        public Employee AddNewEmployee(Employee newEmployee)
        {
            
            _employeeStorage.Create(newEmployee);
            return newEmployee;
        }

        public void UpdateEmployee(Employee updateEmployee) 
        {
            _employeeStorage.Update(updateEmployee);
        }

        // Methods for Leave
        public string Approve(Guid leaveid, string leavestatus)
        {
            var leave = _leaveStorage.GetById(leaveid);
            if(leavestatus=="Approved")
            {
                return "Leave has been Approved";
                _leaveStorage.Approve(leaveid,leavestatus);
            }
            else if(leavestatus=="DisApproved")
            {
                return "Leave has been DisApproved";
                _leaveStorage.Approve(leaveid,leavestatus);
            }
            else
            {
                return "Kindly Provide Correct Status";
            }
            
        }

        public List<Leave> GetAllLeave()
        {
            return _leaveStorage.GetAll();
        }

        public Leave Mark(Leave newLeave)
        {
            _leaveStorage.Mark(newLeave);
            return newLeave;
        }

        
        /*** METHODS ***/
        public List<Holiday> SearchForHoliday(string titleToSearch)
        {
            return _holidayStorage.GetByName(titleToSearch);
        }

        public List<Holiday> GetAllHoliday()
        {
            return _holidayStorage.GetAll();      
        }

        public Holiday GetById(Guid id) 
        {
            return _holidayStorage.GetById(id);
        }


        public void UpdateHoliday(Holiday updateHoliday) 
        {
            _holidayStorage.Update(updateHoliday);
        }

        public Holiday AddNewHoliday(Holiday newHoliday)
        {
            
            _holidayStorage.Create(newHoliday);
            return newHoliday;
        }

        /*** METHODS FOR ATTENDANCE ***/
        public List<Attendance> GetAllAttendance()
        {
            return _attendanceStorage.GetAll();      
        }

        public Attendance AddNewAttendance(Attendance newAttendance)
        {
            
            _attendanceStorage.Mark(newAttendance);
            return newAttendance;
        }
       
        /*** METHODS FOR CONCERN ***/
        public List<Concern> SearchForConcern(string titleToSearch)
        {
            return _concernStorage.GetByName(titleToSearch);
        }

        public List<Concern> GetAllConcern()
        {
            return _concernStorage.GetAll();      
        }

        public Concern AddNewConcern(Concern newConcern)
        {
            
            _concernStorage.Create(newConcern);
            return newConcern;
        }
        public void UpdateConcern(Concern updateConcern)
        {
            _concernStorage.Update(updateConcern);
        }

        public Concern GetByConcernId(Guid id)
        {
            return _concernStorage.GetById(id);
        }
        
    }
}