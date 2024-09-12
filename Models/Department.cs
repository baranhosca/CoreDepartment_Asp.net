using CoreDepartment.Models;
using System.ComponentModel.DataAnnotations;

namespace CoreDepartmant.Models
{
	public class Department
	{
        [Key]
        public int ID { get; set; }
        public string departmentName { get; set; }

        public List<Personel> Personels { get; set; }
    }
}
