using System;
using System.Collections.Generic;
using EmployeeRecords_App.Models;

namespace EmployeeRecords_App.Interfaces
{
    public interface ICompanyRepository
    {
        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
    }
}