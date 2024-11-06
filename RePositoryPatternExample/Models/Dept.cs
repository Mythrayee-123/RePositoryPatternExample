using System.ComponentModel.DataAnnotations;

namespace RePositoryPatternExample.Models
{
    public class Dept
    {
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
