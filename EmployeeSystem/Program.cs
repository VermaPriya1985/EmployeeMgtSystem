using System;
using System.Collections.Generic;
using EmployeeSystem.Storage;
using EmployeeSystem.Models;
namespace EmployeeSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Dependency Injection and init
            
            var employeeStorage = new EmployeeStorageList();
            var leaveStorage = new LeaveStorageList();
            var holidayStorage = new HolidayStorageList();
            var attendanceStorage = new AttendanceStorageList();
            var concernStorage = new ConcernStorageList();

            EmployeeManagement theEmployee = new EmployeeManagement(employeeStorage,
            leaveStorage,holidayStorage,attendanceStorage,concernStorage);
            Console.WriteLine("Welcome to the Employee Management System!");
            
            /* while(true)
            {
                   Console.WriteLine("\nPlease select an option:\n" +
                    "- 1: search a employee\n" + 
                    "- 2: list all employee\n" + 
                    "- 3: list all leave\n" +
                    "- 4: approve a leave\n" + 
                    "- 5: search for a holiday\n" +
                    "- 6: list all holiday\n" +
                    "- 7: list all attendance\n" +
                    "- 8: list all concern\n" + 
                    "- 9: search for concern\n" + 
                    "- q: quit\n"
                );
                string userInput = Console.ReadLine();
                // Search Employee
                if(userInput=="1")
                {
                    try
                    {
                    
                        Console.WriteLine("Enter Employee Name to search for?");
                        string name = Console.ReadLine();
                        List<Employee> result = theEmployee.SearchForEmployee(name);
                        if (result.Count == 0) 
                        {
                            Console.WriteLine("Employee was not found");
                        } 
                        else 
                        {
                            foreach (var employee in result) 
                            {
                                Console.WriteLine("Employee Found:" + employee.FullName.ToString());
                            }
                        }
                    } 
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                 // List all employees
                 if(userInput == "2") 
                 {
                    try 
                    {
                        List<Employee> results = theEmployee.GetAllEmployee();
                        foreach (var employee in results) 
                        {
                            Console.WriteLine(employee.FullName.ToString());
                        } 
                    } 
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                 // List all leave
                 if (userInput == "3") 
                 {
                    try 
                    {
                        List<Leave> results = theEmployee.GetAllLeave();
                        foreach (var leave in results) 
                        {
                            Console.WriteLine(leave.LeaveId.ToString());
                        } 
                    } 
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                // Approve Leave
                if(userInput=="4")
                {
                    try
                    {

                        Console.WriteLine("Enter LeaveID to approve/disapprove for?");
                        string leaveid = Console.ReadLine();
                        
                        Console.WriteLine("Enter ApproveStatus?");
                        string status = Console.ReadLine();
                        
                        string result = theEmployee.Approve(Convert.ToInt64(leaveid),status);
                        if(result == null) 
                        {
                            Console.WriteLine("Please enter correct leaveid and status:" + result);
                        } 
                        else 
                        { 
                            Console.WriteLine(result);
                            
                        }
                    }
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }                 
                }
                
                // Methods For Holiday
                if(userInput=="5")
                {
                    try
                    {
                    
                        Console.WriteLine("Enter Holiday Name to search for?");
                        string name = Console.ReadLine();
                        List<Holiday> result = theEmployee.SearchForHoliday(name);
                        if (result.Count == 0) 
                        {
                            Console.WriteLine("Holiday was not found");
                        } 
                        else 
                        {
                            foreach (var holiday in result) 
                            {
                                Console.WriteLine("Holiday Found:" + holiday.HolidayName.ToString());
                            }
                        }
                    } 
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                 // List all holidays
                 if(userInput == "6") 
                 {
                    try 
                    {
                        List<Holiday> results = theEmployee.GetAllHoliday();
                        foreach(var holiday in results) 
                        {
                            Console.WriteLine(holiday.HolidayName.ToString());
                        } 
                    } 
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                 // List all attendance
                 if(userInput == "7") 
                 {
                    try 
                    {
                        List<Attendance> results = theEmployee.GetAllAttendance();
                        foreach(var attendance in results) 
                        {
                            Console.WriteLine(attendance.AttendanceDate.ToString());
                        } 
                    } 
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                // METHODS CONCERN
                // List all concern
                 if (userInput == "8") 
                 {
                    try 
                    {
                        List<Concern> results = theEmployee.GetAllConcern();
                        foreach (var concern in results) 
                        {
                            Console.WriteLine(concern.ConcernId.ToString());
                        } 
                    } 
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                if(userInput=="9")
                {
                    try
                    {
                    
                        Console.WriteLine("Enter Concern Type to search for?");
                        string name = Console.ReadLine();
                        List<Concern> result = theEmployee.SearchForConcern(name);
                        if (result.Count == 0) 
                        {
                            Console.WriteLine("Concern was not found");
                        } 
                        else 
                        {
                            foreach (var concern in result) 
                            {
                                Console.WriteLine("Concern Found:" + concern.Remarks.ToString());
                            }
                        }
                    } 
                    catch (Exception e) 
                    {
                        Console.WriteLine($"Error: {e.Message}");
                    }
                }

                // Quit
                if(userInput=="q")
                {
                    break;
                }
            
            } */

            // end

        }
    }
}
