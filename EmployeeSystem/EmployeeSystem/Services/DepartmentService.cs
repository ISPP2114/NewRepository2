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
    public class DepartmentService
    {
        private EmployeeSystemContext _context = new();

        public async Task<List<Department>> GetDepartmentsAsync()
        {
            return await _context.Departments.Include(d=>d.Employees).ToListAsync();
        }

        public void DeleteDepartment(Department department)
        {
            _context.Departments.Remove(department);
        }

        public void UpdateDepartment(Department changedDepartment)
        {
            _context.Departments.Update(changedDepartment);
        }

        public async Task AddDepartmentsAsync(Department newDepartment)
        {
            await _context.Departments.AddAsync(newDepartment);
        }
    }
}
