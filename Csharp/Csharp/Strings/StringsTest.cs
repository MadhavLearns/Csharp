using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Strings
{
    public class StringsTest
    {
        public void Strings()
        {
            var firstName = "Madhav";
            var lastName = "Sai";


            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("String.Concat Test");
            List<string> newStrings = new List<string>{"Text ", "is ", "easy ","to ","type" };

            string test = string.Concat(newStrings);
            Console.WriteLine(test);

            Console.WriteLine("-------------------------------------------------------------");

            var fullName = firstName + " " + lastName;
            Console.WriteLine("fullName "+ fullName);
            Console.WriteLine("-----------------------------");
            //firstName[0] = 'm'; // throws error
            var myFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine("myFullName " + myFullName);
            Console.WriteLine("-----------------------------");
            var names = new string[3] { "madhav", "sai", "singanamala" };
            var fullNames = string.Join(",", names);
            Console.WriteLine(fullNames);
            Console.WriteLine("-----------------------------");
            var pathString = "hi can you look into\nthe following paths\nc:\\programfiles\\dotnet1\\dotnet.exe\nc:\\programfiles\\dotnet2\\dotnet.exe";
            Console.WriteLine(pathString);
            Console.WriteLine("-----------------------------");
            var pathString1 = @"hi can you look into
                                the following paths
                                c:\programfiles\dotnet1\dotnet.exe
                                c:\programfiles\dotnet2\dotnet.exe";
            Console.WriteLine(pathString1);
        }
    }
}
