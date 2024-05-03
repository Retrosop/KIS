using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using EntityFrameworkCore.Jet;
using static ConsoleAppAccess.DBModel;

namespace ConsoleAppAccess
{
	internal class DBModel
	{
		public class Client
		{
			[Key]
			public int IdClient { get; set; }
			public string Name{ get; set; }
			public string? Adress { get; set; }
			public string? Telef { get; set; }
			public string? Email { get; set; }
		}
<<<<<<< HEAD
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
=======
		public class Tovar
		{
			[Key]
			public int IdTovar { get; set; }
			public string Name { get; set; }
			public string Edizm { get; set; }
			public decimal Zena { get; set; }
		}
		public class Prihod
		{
			[Key]
			public int IdPrihod { get; set; }
			public int IdTovar { get; set; }
			public int IdPostav { get; set; }
			public DateTime DatPrih { get; set; }
			public int Kolvo { get; set; }
		}

		public class DataContext : DbContext
>>>>>>> bc5bd9b63ea5d14fbe4d91d7cf379b7bbba257c5
		{
			public DbSet<Client> Client { get; set; }

			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\kis\sklad.mdb;");
			}
		}
	}
}


