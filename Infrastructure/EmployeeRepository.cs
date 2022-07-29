using Application.Interface;
using Core;

namespace Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        
        private readonly EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeDbContext.Employees.ToList();
        }
    }
}
