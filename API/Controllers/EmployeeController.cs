using Application.Interface;
using Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _service;

        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            var employees = _service.GetAllEmployees();

            return Ok(employees);
        }
    }
}
