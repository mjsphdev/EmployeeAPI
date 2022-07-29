using Core;

namespace Application.Interface
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
    }
}
