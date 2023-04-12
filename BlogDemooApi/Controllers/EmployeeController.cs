using BlogDemooApi.DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogDemooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.Employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee p)
        {
            using var c = new Context();
            c.Employees.Add(p);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            using var c = new Context();
            var employees = c.Employees.Find(id);
            if (employees == null) { return NotFound(); }
            else { return Ok(employees); }
        }

        [HttpDelete("{id}")]
        public IActionResult EmployeeDelete(int id)
        {
            using var c = new Context();
            var employees = c.Employees.Find(id);
            if (employees == null) { return NotFound(); }
           
            else
            {
                c.Employees.Remove(employees);
                c.SaveChanges();
                return Ok();
            }
           
            
        }

        [HttpPut]
        public IActionResult EmployeeUpdate(Employee p)
        {
            using var c = new Context();
            var values = c.Find<Employee>(p.ID);
            if (values==null) { return NotFound(); }
            else
            {
                values.Name = p.Name;
                c.SaveChanges();
                return Ok();
            }
           
        }
    }
}
