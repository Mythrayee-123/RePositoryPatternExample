using RePositoryPatternExample.Models;

namespace RePositoryPatternExample.Repository
{
	public interface IEmployeeRepository
	{
		List<Employee> GetAllEmployees();

		Employee GetEmployeeById(int id);

		void AddEmployee(Employee emp);

		Employee UpdateEmployee(Employee emp);

		Employee DeleteEmployee(int id);
	}
}
