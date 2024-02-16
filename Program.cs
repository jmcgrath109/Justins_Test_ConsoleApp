using System;
using System.Net.Cache;

namespace Justins_Test_ConsoleApp
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Test";
        public string Description { get; set; } = "Test";
        public string Age { get; set; } = "0";

        public void Introduce()
        {
            Console.WriteLine("Hi my name is " + Name + ". Quick Descripion of me: " + Description + " I am " + Age + " years old" + Id);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var justin = new Person();
            justin.Age = "34";
            justin.Name = "Justin McGrath";
            justin.Description = "I would describe my self as family oriented.";
            justin.Introduce();

        }
    }
}