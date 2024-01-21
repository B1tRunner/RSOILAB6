using System.Collections.Generic;
using EmployeeRecords_App.Models;

namespace EmployeeRecords_App.Interfaces
{
    public interface ILogger
    {
        void LogInfo(string filePath, string message);
        void LogEmployeesListToFile(string filePath, List<Employee> employees);
    }
}