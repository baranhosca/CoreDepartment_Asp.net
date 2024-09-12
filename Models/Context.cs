using CoreDepartmant.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreDepartment.Models
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=BARANPC\\SQLEXPRESS; database=CorePersonel; integrated security=true; TrustServerCertificate=true");
		}

		public DbSet<Department> departments { get; set; }
        public DbSet<Personel> personels { get; set; }
    }
}
