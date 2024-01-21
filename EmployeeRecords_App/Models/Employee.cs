using System;
using EmployeeRecords_App.Enums;

namespace EmployeeRecords_App.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public Position Position { get; set; }
        public DateTime RecrutDate { get; set; }

        public Employee(string fullName, int age, decimal salary, Position position)
        {
            Id = GenerateRandomId();
            FullName = fullName;
            Age = age;
            Salary = salary;
            Position = position;
            RecrutDate = DateTime.Now;
        }
        
        private static int GenerateRandomId()
        {
            var random = new Random();
            var id = random.Next(10000); 
            return id;
        }
    }
}