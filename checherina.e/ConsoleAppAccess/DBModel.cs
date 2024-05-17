using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using EntityFrameworkCore.Jet;
using static ConsoleAppAccess.DBModel;

namespace ConsoleAppAccess
{
	public class DBModel
	{
		public class ComboboxItem
		{
			public string Text { get; set; }
			public int Value { get; set; }

			public override string ToString()
			{
				return Text;
			}
			public string ToKey()
			{
				return Value.ToString();
			}
		}
		public class Client
		{
			[Key]
			public int Id { get; set; }
			public string? NameClient { get; set; }
			public string? Adress { get; set; }
			public string? Telef { get; set; }
			public string? Email { get; set; }
			public DateTime? DateBirthday { get; set; }
			public bool Gender { get; set; }

		}
		//Поставщик продукции
		public class Supplier
		{
			[Key]
			public int Id { get; set; }
			//Название поставщика
			public string Name { get; set; }
			//Город
			public string? City { get; set; }
			//Улица
			public string? Street { get; set; }
			//Телефон
			public string? Phone { get; set; }

		}
		public class Product
		{
			[Key]
			public int Id { get; set; }
			//Название товара
			public string Name { get; set; }
			//Единица измерения товара
			public string Measurement { get; set; }
			//Цена товара
			public float Price { get; set; }
		}
		public class Prihod
		{
			[Key]
			public int Id { get; set; }
			public int IdTovar { get; set; }
			public int IdPostav { get; set; }
			public DateTime DatPrih { get; set; }
			public int Kolvo { get; set; }
		}

//База данных Авиаперелетов
		public class Person
		{
			[Key]
			public int Id { get; set; }
			public string? First_name { get; set; }
			// имя пассажира
			public string? Last_name { get; set; }
			//фамилия пассажира
			public string? Email { get; set; }
			//почта
			public string? Phone { get; set; }
			//номер телефона
			public int Age { get; set; }
			//возраст

		}

		public class Ticket
		{
			[Key]
			public int Id { get; set; }
			public string? Ticket_Number { get; set; }
			public string? Departure { get; set; }
			public string? Destination { get; set; }
			public string? Departure_Time { get; set; }
			public string? Arrival_Time { get; set; }
			public string? Type_Passange { get; set; }
			public string? Privileges { get; set; }
			public string? Place_Number { get; set; }
			public string? Place_Letter { get; set; }
		}
		public class Airplane
		{
			[Key]
			public int Id { get; set; }
			public string? Airline { get; set; }
			public string? Airplane_Model { get; set; }
			public string? Capacity { get; set; }
		}

		public class DataContext : DbContext
		{
			public DbSet<Client> Client { get; set; }
			public DbSet<Product> Product { get; set; }
			public DbSet<Supplier> Supplier { get; set; }

			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\kis\checherina.e\sklad.mdb;");
			}
		}

	}
}


