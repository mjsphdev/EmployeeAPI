
using Core;
using Application.Interface;

namespace Application.Services
{
    public class EmployeeService : IEmployeeService 
    {
        public readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public List<Employee> GetAllEmployees()
        {
            var employees = _employeeRepository.GetAllEmployees(); 

            return employees;   
        }
    }
}
