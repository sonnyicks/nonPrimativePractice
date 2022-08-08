using nonPrimativePractice.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonPrimativePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var sonny = new Person();
            //sonny.firstName = "Sonny";
            //sonny.lastName = "Icks";
            //sonny.Introduce();
            //var calc1 = new Calculator();
            //var sum = calc1.Add(1, 2);
            //System.Console.WriteLine(sum);

            var numbers = new int[3];
            numbers[0] = 1;

            System.Console.WriteLine(numbers[0]);
            //initialized to 0 be default
            System.Console.WriteLine(numbers[1]);
            System.Console.WriteLine(numbers[2]);

            var flags = new bool[3];
            flags[0] = true;

            System.Console.WriteLine(flags[0]);
            System.Console.WriteLine(flags[1]);
            System.Console.WriteLine(flags[2]);

            var names = new string[3] {"Jack", "John", "Mary"};
            foreach(var e in names)
            {
                System.Console.WriteLine(e);
            }

        }
    }
}
