using Csharp.Arrays;
using Csharp.Classes;
using Csharp.ControlFlowExercises;
using Csharp.Enums;
using Csharp.Operators;
using Csharp.RefTypesAndVariableTypes;
using Csharp.Strings;
using Csharp.Struct;
using Csharp.Variables;
using System;
using System.Collections.Generic;
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
            //ArrayTest1 arrays = new ArrayTest1();
            //arrays.RunProgram();
            #endregion
            #region strings
            //StringsTest stringTest = new StringsTest();
            //stringTest.Strings();
            StringMethods sm = new StringMethods();
            sm.TestMethods();
            #endregion
            #region Enums
            //EnumTest test = new EnumTest();
            //test.TestEnum();
            #endregion
            #region ReferenceTypes and Variable Types
            //RefTest refTest = new RefTest();
            //refTest.TestRefAndVarTypes();
            #endregion

            #region ControlFlow
            //var cf1 = new CF1();
            //cf1.RunProgram();
            //var cf2 = new CF2();
            //cf2.RunProgram();
            //var cf3 = new CF3();
            //cf3.RunProgram();
            //var cf4 = new CF4();
            //cf4.RunProgram();
            #endregion

            #region Read-Only
            //ReadOnlyTest rd = new ReadOnlyTest();
            //Console.WriteLine(rd.displayVar());
            #endregion

        }
    }
}
