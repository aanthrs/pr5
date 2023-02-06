using HashPassword;
using System;

namespace Регистрация
{
	class Program
	{
		static void Main(string[] args)
		{
			Model.КлиникаEntities1 db = new Model.КлиникаEntities1();
			var myUser = new Model.Users();
			Console.Write("Регистрация пользователя");
			

			Console.Write("Введите логин: ");
			myUser.Login= Console.ReadLine();
			Console.Write("Введите ФИО: ");
			myUser.FIO_pacienta = Console.ReadLine();
			Console.Write("Введите пароль: ");
			string hashPassword = sha256Hash.GetHashPassword(Console.ReadLine());
			myUser.Password = hashPassword;
			Console.WriteLine("Новый хэшированный пароль" + hashPassword);
			Console.Read();

			db.Users.Add(myUser);
			db.SaveChanges();

			
			

		}
	}
}