using AppWebAPI.Models;
using AppWebAPI.Repositry.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployee employeeService;
        public EmployeesController(IEmployee Employees)
        {
            employeeService = Employees;
        }
        [HttpGet]
        public IActionResult Get() 
        {
            var results = employeeService.GetEmployees();
            if (results.Count > 0)
            {
                return Ok(results);
            }
            else
            {
                return NotFound("Employee not found !");
            }
        }
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            var result = employeeService.PostEmployee(employee);
            if(result!=null)
            {
                return Ok(result);

            }
            else
            {
                return Ok();
            }
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();

            }
            else
            {

                var result = employeeService.DeleteEmployee(id);
           
                 if(result != null)
                 {
                return Ok(result);

                 }
            else
            {
                return NotFound();
               
                
                }
                 }
        }

        [HttpPut]
        [Route("Update/{Id}")]
        public IActionResult update(Employee emp)
        {
            if (emp == null)
            {
                return BadRequest();

            }
            else
            {
                var result = employeeService.UpdateEmloyee(emp);
                if (result != null)
                {
                    return Ok(result);

                }
                else
                {
                    return NotFound();
                }
            }
        }
    }


}
