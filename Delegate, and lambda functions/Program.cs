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
    }

    public class Program
    {
        private Person Person1 { get; set; }

        private static void Main()
        {
            var program1 = new Program(){Person1 = new Person(){Id = 1,Name = "Ali"}};
            ShowDelegate callShow = program1.Person1.Show;
            callShow();
            Console.ReadKey();
        }
    }
}
