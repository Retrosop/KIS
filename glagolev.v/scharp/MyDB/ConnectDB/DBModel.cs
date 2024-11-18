using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ConnectDB
{
	public class Goods
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public int Cena { get; set; }

	}

	public class DataContext : DbContext
	{
		public DbSet<Goods> Glagolev_Goods1 { get; set; }


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql("server=91.219.194.4;user=bh35910_student1711;password=pgu2023pgu2023;database=bh35910_kis;", new MySqlServerVersion(new Version(10, 6, 0)));
		}
	}

}
