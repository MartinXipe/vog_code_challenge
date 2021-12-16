using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Entities;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;

        public EmployeesController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        [HttpGet("")]
        public IActionResult GetEmployees()
        {
            IList<Employee> employees = _employeesService.ListAll();
            return Ok(employees);
        }

        [HttpGet("department/{departmentId}")]
        public IActionResult GetEmployeesByDepartment(int departmentId)
        {
            IList<Employee> employees = _employeesService.ListAll();
            return Ok(employees.Where(x => x.DepartmentId.Equals(departmentId)).ToList());
        }
    }
}
