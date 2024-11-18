using System;
using ConnectDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
class MyProgram
{
	static void Main()
	{
		using (DataContext db = new DataContext())
		{
			Goods g1 = new Goods();
			g1.Name = "Телевизор";
			g1.Cena = 3800;
			db.Glagolev_Goods1.Add(g1);
			db.SaveChanges();
		}
	}
}