using System;
using System.Text;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Employee employee = new Employee("Позіхайло", "Максим");
     
            employee.SetVacancy("Програміст");
            employee.SetExperience(1);

            employee.CalculateSalary();

            employee.Print();
        }
    }

}
