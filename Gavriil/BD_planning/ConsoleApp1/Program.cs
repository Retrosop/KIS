using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{

	public class Client
	{
		public int ClientId { get; set; }
		public string Lastname { get; set; }
		public string Firstname { get; set; }
		private int age = 0;
		public string Passport { get; set; }
		public decimal Height { get; set; }
		public decimal Netto { get; set; }

		public int Age
		{
			get { return age; }
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Возраст должен быть больше 0");
				}
				age = value;
			}
		}
	}

	public class Order
	{
		public int OrderId { get; set; }
		public int OrderNumber { get; set; }
		public int ClientId { get; set; }
		public Client Client { get; set; }
		public int ItemId { get; set; }
		public Item Item { get; set; }
	}

	public class Item
	{
		public int ItemId { get; set; }
		public string Category { get; set; }
		public int Cost { get; set; }
		public int Sale { get; set; }
		public string Name { get; set; }
		public string Rank { get; set; }
		public string Status { get; set; }
	}

	public class AppDbContext : DbContext
	{
		public DbSet<Client> Clients { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Item> Items { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=C:\\kis\\Gavriil\\BD_planning\\ConsoleApp1\\app.db");
		}
	}


}

