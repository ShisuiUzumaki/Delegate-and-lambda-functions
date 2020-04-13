using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Delegate__and_lambda_functions
{
    public delegate void ShowDelegate();

    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

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
            ShowDelegate callShow = program1.Person1.Show;
            callShow();

            //Checking built in delegates

            //Action delegate
            Action action1 = program1.Person1.Show;
            action1();

            //Action with arguments
            Action<int> action2 = program1.Show;
            action2(12);

            //Func without args
            Func<int> func1 = program1.Person1.GetUserId;
            Console.WriteLine(func1());

            //Func with args
            Func<Person, bool> func2 = program1.CreatePerson;
            Console.WriteLine(func2(program1.Person1));

            //predicate
            Predicate<bool> pred = (bool x) => x;
            Console.WriteLine(pred(true));

            Console.ReadKey();
        }

        private bool CreatePerson(Person arg)
        {
            
            return arg.IsValidUser();

        }

        public void Show(int x)
        {
            Console.WriteLine(x);
        }
    }


}
