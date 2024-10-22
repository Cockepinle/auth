using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorizations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           UsersRepository usersRepo = new UsersRepository(); // Реальный репозиторий для работы с БД
           //StubUserRepository usersRepo = new StubUserRepository(); // Заглушка для тестирования

            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            if (usersRepo.Authenticate(login, password))
            {
                Console.WriteLine("Авторизация успешна!");
            }
            else
            {
                Console.WriteLine("Неверный логин или пароль.");
            }
        }
    
}
}
