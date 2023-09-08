using System;

namespace Task3
{
    class Employee
    {
        private string lastName;
        private string firstName;
        private string vacancy;
        private double salary;
        private int work_experience;
        private double tax;

        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public void SetVacancy(string vacancy)
        {
            this.vacancy = vacancy;
        }

        public void SetExperience(int work_experience)
        {
            this.work_experience = work_experience;
        }

        public void CalculateSalary()
        {
            double baseSalary = 30000;
            if (vacancy == "Менеджер")
            {
                baseSalary = 15000;
            }
            else if (vacancy == "Вчитель")
            {
                baseSalary = 20000;
            }
            else if (vacancy == "Програміст")
            {
                baseSalary = 35000;
            }

            double experienceBonus = work_experience * 1000;

            salary = baseSalary + experienceBonus;

            tax = salary * 0.15; // 15%
        }

        public void Print()
        {
            Console.WriteLine($"Прізвище: {lastName}\n" +
                $"Ім'я: {firstName}\n" +
                $"Посада: {vacancy}\n" +
                $"Оклад: {salary}\n" +
                $"Податковий збір: {tax}\n");
        }
    }
}
