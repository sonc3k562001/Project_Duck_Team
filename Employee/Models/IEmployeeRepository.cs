
using System.Linq;


namespace Employee.Models
{
    public interface IEmployeeRepository
    {
        IQueryable<Employee> Employees { get; }
    }
}
