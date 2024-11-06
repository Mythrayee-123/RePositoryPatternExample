using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RePositoryPatternExample.Models
{
	public class Employee
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Employeeid { get; set; }
		public string Name { get; set; }
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Display(Name ="Department Name")]
		public int DeptId { get; set; }
		public Dept? Dept { get; set; }
	}
}
