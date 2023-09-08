using System;

namespace Task4
{
    class User
    {
        public string Login;
        public string FirstName;
        public string LastName;
        public int Age;
        public DateTime RegistrationDate;

        public User(string login, string firstName, string lastName, int age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"Логін: {Login}\n" +
                            $"Ім'я: {FirstName}\n" +
                            $"Прізвище: {LastName}\n" +
                            $"Вік: {Age}\n" +
                            $"Дата заповнення анкети: {RegistrationDate}\n");
        } 
    }
}
