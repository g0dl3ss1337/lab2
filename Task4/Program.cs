using System;
using System.Text;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            User user = new User("g0dl3ss1337", "Максим", "Позіхайло", 18);
            user.Print();
        }
    }

}
