using System;
using System.Collections.Generic;
using EmployeeRecords_App.Models;

namespace EmployeeRecords_App.Interfaces
{
    public interface IEmployeeManager
    {
        void RecruitEmployee(Employee employee);
        void TerminateEmployee(int employeeId);
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
    }
}