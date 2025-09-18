using EmployeeSystem.Data;
using EmployeeSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSystem.Services
{
    public class EmployeeService
    {
        private EmployeeSystemContext _context = new();

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _context.Employees.Include(e=>e.Department).ToListAsync();
        }

        public void DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
        }

        public void UpdateEmployee(Employee changedEmployee)
        {
            _context.Employees.Update(changedEmployee); 
        }

        public async Task AddEmployeesAsync(Employee newEmployee)
        {
            await _context.Employees.AddAsync(newEmployee);
        }
    }
}
