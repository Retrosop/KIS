using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{

		static void Main(string[] args)
		{
			using (AppDbContext db = new AppDbContext())
			{

				//Добавление записей в таблицу Товары
				Item t1 = new Item();
				t1.Name = "Тестов Тест";
				t1.Category = "Тестов Тест";
				t1.Cost = 1;
				t1.Sale = 2;
				t1.Rank = "2";
				t1.Status = "3";



				db.Items.Add(t1);
				db.SaveChanges();

				t1 = db.Items.SingleOrDefault(s => s.ItemId == 1);
				if (t1 != null)
				{
					t1.Name = "454545";
					db.SaveChanges();
				}

				//Удаление строки в таблице Клиенты с первичным ключом Id=2
				t1 = db.Items.SingleOrDefault(s => s.ItemId == 4);
				if (t1 != null)
				{
					//удаляем объект
					db.Items.Remove(t1);
					db.SaveChanges();
				}

				//Выборка все названий товаров
				var allitem = db.Items.Select(x => x.Name);
				foreach (var xname in allitem)
				{
					Console.WriteLine($"{xname}");
				}

				//Выборка всех товаров
				var allClient = db.Items;
				foreach (var xitem in allClient)
				{
					Console.WriteLine($"{xitem.Name} - {xitem.Category}");
				}

			}
		}
	}
}