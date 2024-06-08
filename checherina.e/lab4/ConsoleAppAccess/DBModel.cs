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
			public string? Ticket_number { get; set; }
			// номер билета
			public string? Departure { get; set; }
			// место вылета
			public string? Destination { get; set; }
			// место прибытия
			public string? Departure_time { get; set; }
			// время вылета
			public string? Arrival_time { get; set; }
			// время прибытия
			public string? Type_passange { get; set; }
			// тип пассажирского места (эконом, комфорт, бизнес)
			public string? Privileges { get; set; }
			// льготы пассажира
			public string? Place_number { get; set; }
			// номер места
			public string? Place_letter { get; set; }
			// буква места
		}
		public class Airplane
		{
			[Key]
			public int Id { get; set; }
			public string? Airline_name { get; set; }
			// наименование авиакомании
			public string? Airplane_model { get; set; }
			// модель самолёта
			public string? Capacity { get; set; }
			// вместимость самолёта
		}
		public class DataContext : DbContext
		{
			public DbSet<Person> Person { get; set; }
			public DbSet<Ticket> Ticket { get; set; }
			public DbSet<Airplane> Airplane { get; set; }
		}
		public class DataContext : DbContext
		{
			public DbSet<Client> Client { get; set; }
			public DbSet<Product> Product { get; set; }
			public DbSet<Supplier> Supplier { get; set; }

			protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
			{
				optionsBuilder.UseJet(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ekuty\Desktop\kis1\kis\checherina.e\sklad.mdb;");
			}
		}

		
	}
}


