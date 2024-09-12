using CoreDepartmant.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDepartment.Models
{
	public class Personel
	{
        [Key]
        public int personalID { get; set; }
		public string personalName { get; set; }
        public string personalSurname { get; set; }
        public string personalCity { get; set; }
        public Department depart { get; set; }
    }
}
