using System;
using System.Collections.Generic;
using EmployeeRecords_App.Interfaces;
using EmployeeRecords_App.Models;

namespace EmployeeRecords_App
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly ICompanyRepository _companyRepository;

        public EmployeeManager(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void RecruitEmployee(Employee employee)
        {
            _companyRepository.AddEmployee(employee);
        }

        public void TerminateEmployee(int employeeId)
        {
            var employee = _companyRepository.GetEmployeeById(employeeId);
            if (employee != null)
            {
                _companyRepository.DeleteEmployee(employee);
            }
        }

        public List<Employee> GetAllEmployees()
        {
            return _companyRepository.GetAllEmployees();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return _companyRepository.GetEmployeeById(employeeId);
        }
    }
}