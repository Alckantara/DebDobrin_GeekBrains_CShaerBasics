using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

using ClassLibrary.Interfaces;
using ClassLibrary.Helpers;
using ClassLibrary;

namespace Lesson4
{
    public class Task4 : ITask
    {
        private readonly Account savedUserAccount = new Account(login: "root", password: "GeekBrains");
        private string filePath;

        private struct Account
        {
            public string Login { get; init; }
            public string Password { get; init; }

            public Account(string login, string password) =>
                (Login, Password) = (login, password);

            public void Print(string prefix = "") =>
                Helper.PrintLine($"{ prefix }login: { Login }, password: { Password }");

            public void Deconstruct(out string login, out string password) => 
                (login, password) = (Login, Password);
        }

        public void Start()
        {
            Console.Clear();

            Helper.PrintLine("Введите название файла");
            filePath = Console.ReadLine();
            Helper.PrintLine($"Вы указали путь: { Environment.NewLine }{ Path.GetFullPath(filePath) }");

            while (!File.Exists(filePath)) 
            {
                Helper.PrintLine("Файл не существует. Попробуйте снова:");
                filePath = Console.ReadLine();
                Helper.PrintLine($"Вы указали путь: { Environment.NewLine }{ Path.GetFullPath(filePath) }");
            }


            Account[] validUsers = ValidateAllUsers();

            if (validUsers is null)
                Helper.PrintLine("В файле нет валидных пользователей");

            Helper.PrintLine($"Список авторизировавшихся пользователей:{ Environment.NewLine }");
            for (int i = 0; i < validUsers.Count(); i++)
            {
                validUsers[i].Print($"{ i }) ");
            }
        }

        private Account[] ValidateAllUsers() 
        {
            Account[] users = readUserData(filePath);

            if (users is null)
                return null;

            Account[] validUsers = new Account[users.Length];

            Account[] savedUsersAccounts = { savedUserAccount };

            int validCounter = 0;
            foreach (Account user in users)
            {
                if (isUserDataValid(user, savedUsersAccounts))
                    validUsers[validCounter++] = user;
            }

            return validUsers;
        }

        private bool isUserDataValid(Account userAccount, Account[] validAccounts) =>
            validAccounts.Contains(userAccount);

        private Account[] readUserData(string filePath)
        {
            int length = File.ReadAllLines(filePath).Length;

            if (length == 0)
            {
                Helper.PrintLine("В файле должна быть хоть одна строка");
                return null;
            }
            else if (length >= 3)
            {
                Helper.PrintLine("В файле должно быть не более 3-х строк (попыток)");
                return null;
            }
            

            Account[] users = new Account[length];

            using (StreamReader reader = new StreamReader(filePath))
            {
                int i = 0;
                while (!reader.EndOfStream)
                {
                    var useraData = reader.ReadLine().Split(" ");
                    users[i] = new Account(useraData[0], useraData[1]);
                    i++;
                }
            }

            return users;
        }
    }
}
