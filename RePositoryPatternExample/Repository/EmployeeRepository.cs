using Microsoft.EntityFrameworkCore;
using RePositoryPatternExample.Models;

namespace RePositoryPatternExample.Repository
{
	public class EmployeeRepository : IEmployeeRepository
	{

		private readonly EFCoreDBContext _context;

		//DI
		public EmployeeRepository(EFCoreDBContext context)
		{
			_context = context;
		}
		public void AddEmployee(Employee emp)
		{
			//Actual logic 
			_context.Employees.Add(emp);
			_context.SaveChanges();
		}

		public Employee DeleteEmployee(int id)
		{
			throw new NotImplementedException();
		}

		public List<Employee> GetAllEmployees()
		{
			return _context.Employees.Include(x=>x.Dept).ToList();
		}

		public Employee GetEmployeeById(int id)
		{
			throw new NotImplementedException();
		}

		public Employee UpdateEmployee(Employee emp)
		{
			throw new NotImplementedException();
		}
	}
}
