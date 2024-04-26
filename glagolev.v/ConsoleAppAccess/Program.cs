using System;
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
				//add

				//Client cl1 = new Client();
				//cl1.NameClient = "Максимов Степан";
				//cl1.Telef = "41112";
				//cl1.Adress = "Широкая 32";
				//cl1.Email = "re@mail.ru";


				//db.Client.Add(cl1);
				//db.SaveChanges();


				//update
				Client s2 = db.Client.SingleOrDefault(s => s.Id == 1);
				if (s2 != null)
				{
					s2.Telef = "454545";
					db.SaveChanges();
				}

				//delete

				Client s1 = db.Client.SingleOrDefault(s => s.Id == 2);
				if (s1 != null)
				{
					//удаляем объект
					db.Client.Remove(s1);
					db.SaveChanges();
				}


				//select
				var sall = db.Client.Select(x => x.Telef);
				foreach (var s in sall)
				{
					Console.WriteLine($"{s}");
				}

				var sall1 = db.Client;
				foreach (var xs in sall1)
				{
					Console.WriteLine($"{xs.NameClient} - {xs.Telef}");
				}
				Console.WriteLine("HW");
			}
		}
	}
}