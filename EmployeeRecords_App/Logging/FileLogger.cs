using System;
using System.Collections.Generic;
using System.IO;
using EmployeeRecords_App.Interfaces;
using EmployeeRecords_App.Models;
using Newtonsoft.Json;

namespace EmployeeRecords_App.Logging
{
    public class FileLogger : ILogger
    {
        public void LogInfo(string filePath, string message)
        {
            var date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            File.AppendAllText(filePath, $"{date} {message}\n");
            Console.WriteLine($"{date} {message}");
        }

        public void LogEmployeesListToFile(string filePath, List<Employee> employees)
        {
            var json = JsonConvert.SerializeObject(employees, Formatting.Indented);
            File.WriteAllText(filePath, json);
            Console.WriteLine($"Список сотрудников записан в файл: {filePath}");
        }
    }
}