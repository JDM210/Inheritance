using System;

namespace joshinherit
{
    public class User
    {
        public string Name;
        private string Location;
        public User()
        {
            Console.WriteLine("Inheritance Assignment");
        }
        public void GetUserInfo(string loc)
        {
            Location = loc;
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
        }
    }
    public class Info : User
    {
        public int Age;
        public Info()
        {
            Console.WriteLine("OOP 2022");
        }
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Info d = new Info();
            d.Name = "Josh Munday";
            d.Age = 29;
            d.GetUserInfo("Bradford, PA");
            d.GetAge();
            Console.WriteLine("\nThank You");
            Console.ReadLine();
        }
    }
}
