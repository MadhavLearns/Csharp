using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Strings
{
    public class StringMethods
    {
       

       public void TestMethods()
        {
            string name = "Madhava Sai ";

            Console.WriteLine(name.Trim());
            Console.WriteLine("To Upper: '{0}'",name.Trim().ToUpper());
            Console.WriteLine("To Lower: '{0}'", name.Trim().ToLower());

            var index = name.IndexOf(' ');
            var firstName = name.Substring(0, index); //Takes till index
            var lastName = name.Substring(index + 1);
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);

            var names = name.Split(' ');

            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            var num = "1234";

            var number = Convert.ToInt32(num); // This method gives default values if the input string has null.
            var number1 = int.Parse(num); // This method throws exception when input string is null;

            var num1 = 29.01f;
            var numberToString = num1.ToString("C0");
            Console.WriteLine(numberToString);
        }
    }
}
