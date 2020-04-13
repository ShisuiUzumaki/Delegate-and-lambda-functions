using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Delegate__and_lambda_functions
{
    public delegate void ShowDelegate(int x);

    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static void Method(int x)
        {
            Console.WriteLine($"Static method called : {x}");
        }

        public void Show()
        {
            if (Name != null) Console.Write($"My name is: {Name}");
        }

        public int GetUserId() => Id;

        public bool IsValidUser() => Id >= 0;
    }

    public class Program
    {
        private Person Person1 { get; set; }

        private static void Main()
        {
            var program1 = new Program(){Person1 = new Person(){Id = 1,Name = "Ali"}};
            ShowDelegate sd = program1.Func1;
            sd += program1.Func2;
            sd(1);
            sd -= program1.Func1;
            sd(2);

            sd = Person.Method;
            sd(12);
            Console.ReadKey();
            // hello world
            //one more comment
            // we can't pass more than one argument one predicate

        }

        public void Func1(int x)
        {
            Console.WriteLine($"From func1 :{x}");
        }

        public void Func2(int y)
        {
            Console.WriteLine($"From func2 :{y}");
        }

    }


}
