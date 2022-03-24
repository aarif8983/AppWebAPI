﻿using AppWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebAPI.Repositry.Contract
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee PostEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        Employee DeleteEmployee(int id);
        Employee UpdateEmloyee(Employee emp);
    }
}
