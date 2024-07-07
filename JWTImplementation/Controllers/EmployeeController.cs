using JWTImplementation.Interfaces;
using JWTImplementation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

namespace JWTImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;
     
        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        [HttpGet]
        public List<Employee> GetEmployees()
        {
            var emp=_employeeServices.GetEmployeeDetails();
            return emp;
        }

        [HttpGet("GetByID")]
        public Employee GetByID(int id)
        {
            var emp=_employeeServices.GetEmployeeDetailsBYID(id);
            return emp;
        }
        [HttpPost]
        public Employee Post([FromBody] Employee emp)
        {
            var empployee = _employeeServices.AddEmployee(emp);
            return empployee;
        }
        [HttpPut]
        public Employee Put([FromBody] Employee emp)
        {
            var empployee = _employeeServices.UpdateEmployee(emp);
            return empployee;
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            var emp = _employeeServices.DeleteEmployee(id);
            return emp;
        }
    }
}
