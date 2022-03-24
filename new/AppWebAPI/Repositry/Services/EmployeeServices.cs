using AppWebAPI.Models;
using AppWebAPI.Repositry.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebAPI.Repositry.Services
{
    public class EmployeeServices : IEmployee
    {
        private  AppDbContext dbContext;
        public EmployeeServices(AppDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Employee DeleteEmployee(int id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.Id == id);
            if(emp != null)
            { 
             dbContext.Employees.Remove(emp);
              dbContext.SaveChanges();
             return emp;
            }
            else
            {
                return (null);
            }
        }

        public Employee GetEmployeeById(int id)
        {
           var emp=dbContext.Employees.SingleOrDefault(e=>e.Id==id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }

        public Employee PostEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Employee UpdateEmloyee(Employee emp)
        {
            var empl = dbContext.Employees.SingleOrDefault(e => e.Id == emp.Id);
            if (empl != null)
            {
                empl.FirstName = emp.FirstName;
                empl.LastName = emp.LastName;
                empl.Email = emp.Email;
                empl.Address = emp.Address;
                dbContext.Employees.Update(empl);
                dbContext.SaveChanges();
                return empl;
            }
            else
            {
                return (null);
            }

        }

    }

}

     
