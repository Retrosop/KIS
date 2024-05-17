using System;
using System.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using static ConsoleAppAccess.DBModel;


namespace ConsoleAppAccess
{
	//class Operate
	//{
	//	public void Add(DataContext db, string fio, DateTime dateroj, int age, bool pol)
	//	{
	//		Sotrudnik sotr = new Sotrudnik() { Fio = fio, Age = age, Dater = dateroj, Pol = pol };
	//		db.Sotrudnik.Add(sotr);
	//		db.SaveChanges();
	//	}
	//}
	class Program
	{

		static void Main(string[] args)
		{
			//	Добавление
			using (DataContext db = new DataContext())
			{
				//Добавление записей в таблицу Клиенты
				Client newClient = new Client();
				newClient.NameClient = "Тестов Тест";
				newClient.Telef = "11111";
				newClient.Adress = "Тестовая улица, 1";
				newClient.Email = "test@mail.ru";
				//Дата рождения 1 декабря 2000 года
				newClient.DateBirthday = new DateTime(2000,12,01);
				//Пол, true - мужской
				newClient.Gender = true;
				db.Client.Add(newClient);
				db.SaveChanges();


				//Обновление телефона клиента в строке с первичным ключом Id = 1 в таблице Клиенты
				newClient = db.Client.SingleOrDefault(s => s.Id == 1);
				if (newClient != null)
				{
					newClient.Telef = "454545";
					db.SaveChanges();
				}

				//Удаление строки в таблице Клиенты с первичным ключом Id=2
				newClient = db.Client.SingleOrDefault(s => s.Id == 2);
				if (newClient != null)
				{
					//удаляем объект
					db.Client.Remove(newClient);
					db.SaveChanges();
				}

				//Выборка все телефонов клиентов из таблицы Клиенты
				var allTelef = db.Client.Select(x => x.Telef);
				foreach (var xtelef in allTelef)
				{
					Console.WriteLine($"{xtelef}");
				}

				//Выборка всех клиентов из таблицы Клиенты
				var allClient = db.Client;
				foreach (var xclient in allClient)
				{
					Console.WriteLine($"{xclient.NameClient} - {xclient.Telef}");
				}

                //Найти товары дороже 10 рублей.
                //Select tovar as ‘Товар’ from tovar where zena > 10
                Console.WriteLine("Найти товары дороже 10 рублей\r\n");

				Product newProduct = new Product();
				newProduct.Name = "Телевизор";
				newProduct.Measurement= "шт";
				newProduct.Price = 5000;
				db.Product.Add(newProduct);
				db.SaveChanges();
				
				newProduct = new Product();
				newProduct.Name = "Ручка";
				newProduct.Measurement = "шт";
				newProduct.Price = 5.99f;
				db.Product.Add(newProduct);
				db.SaveChanges();

				var allProduct = db.Product.Where(x => x.Price > 10).Select(x => x);
				foreach (var xtovar in allProduct)
				{
					Console.WriteLine($"{xtovar.Name}");
				}

			}
		}
	}
}