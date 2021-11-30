using Csharp.Arrays;
using Csharp.Classes;
using Csharp.Enums;
using Csharp.Operators;
using Csharp.Strings;
using Csharp.Struct;
using Csharp.Variables;
using System;
using static Csharp.Struct.TestStruct;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            //VariableInitiaization.Run();
            #endregion
            #region Overflowing
            //OverFlowing.OverFlowTest();
            #endregion
            #region TypeConversions
            //TypeConversions.Conversions();
            #endregion
            #region Operators
            //OperatorsTest.OperatorTest();
            #endregion
            #region class
            //var person = new Person();
            //person.firstName = "Madhav";
            //person.lastName = "Sai";
            //person.Initialize();
            #endregion
            #region struct
            //TestStruct test;
            //test.id = 3;
            //test.person = "madhav";
            //Console.WriteLine( test.id +" "+ test.person);
            //classPerson testperson;
            //testperson.firstName = "Madhav";
            //testperson.lastName = "Sai";
            //Console.WriteLine("without object: " + testperson.firstName + " "+testperson.lastName);
            //classPerson testPerson = new classPerson();
            //Console.WriteLine("with object: "+testPerson.firstName + " "+testPerson.lastName);
            #endregion
            #region Arrays
            //ArrayTest arrays = new ArrayTest();
            //arrays.TestArrays();
            #endregion
            #region strings
            //StringsTest stringTest = new StringsTest();
            //stringTest.Strings();
            #endregion
            #region Enums
            EnumTest test = new EnumTest();
            test.TestEnum();
            #endregion
        }
    }
}
