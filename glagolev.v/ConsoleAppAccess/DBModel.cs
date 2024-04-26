using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using EntityFrameworkCore.Jet;

namespace ConsoleAppAccess
{
	internal class DBModel
	{
		public class Client
		{
			[Key]
			public int Id { get; set; }
			public string? NameClient{ get; set; }
			public string? Adress { get; set; }
			public string? Telef { get; set; }
			public string? Email { get; set; }
		}
		public class DataContext : DbContext
		{
			public DbSet<Client> Client { get; set; }

			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\kis\sklad.mdb;");
			}
		}
	}
}


