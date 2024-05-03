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
		/*
        Название поля   Смысл					Тип			Длина
			IdPostav    Номер поставщика		Int			11
			Postav		Наименование поставщика VarChar		50
			Gorod		Город поставщика		VarChar		20
			Ulica		Улица поставщика		VarChar		20
			Telef		Телефон поставщика		VarChar		15

		*/

		public class Postav
		{
			public int IdPostav { get; set; }
			public string? NamePostav { get; set; }
            public string? Gorod { get; set; }
            public string? Ulica { get; set; }
            public string? Telef { get; set; }


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


