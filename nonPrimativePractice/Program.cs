using nonPrimativePractice.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nonPrimativePractice
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    public class Persona
    {
        public int Age;
    }
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

            //var numbers = new int[3];
            //numbers[0] = 1;

            //System.Console.WriteLine(numbers[0]);
            ////initialized to 0 be default
            //System.Console.WriteLine(numbers[1]);
            //System.Console.WriteLine(numbers[2]);

            //var flags = new bool[3];
            //flags[0] = true;

            //System.Console.WriteLine(flags[0]);
            //System.Console.WriteLine(flags[1]);
            //System.Console.WriteLine(flags[2]);

            //var names = new string[3] {"Jack", "John", "Mary"};
            //foreach(var e in names)
            //{
            //    System.Console.WriteLine(e);
            //}

            //var firstName = "Sonny";
            //var lastName = "Icks";

            //var fullName = firstName + " " + lastName;

            //var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            //var names = new string[3] { "John", "Jack", "Mary" };
            //var formattedNames = string.Join(", ", names);
            //Console.WriteLine(myFullName);
            //Console.WriteLine(formattedNames);

            //casting
            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodID = 3;

            //Console.WriteLine((ShippingMethod)methodID);

            //Console.WriteLine(method);

            //var methodName = "Express";
            //var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            //value vs. reference
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(String.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(array1[0]);

            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Persona() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Persona person)
        {
            person.Age += 10;
        }
    }
}
