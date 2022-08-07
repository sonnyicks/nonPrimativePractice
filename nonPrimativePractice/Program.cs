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
            var sonny = new Person();
            sonny.firstName = "Sonny";
            sonny.lastName = "Icks";
            sonny.Introduce();
            var calc1 = new Calculator();
            var sum = calc1.Add(1, 2);
            System.Console.WriteLine(sum);
        }
    }
}
