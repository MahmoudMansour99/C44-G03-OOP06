using Demo.Built_In_Interfaces;
using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Shallow Copy & Deep Copy
            #region Array of Value Type
            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];

            //Console.WriteLine($"Hash code of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash code of Arr01 = {Arr02.GetHashCode()}");

            #region Shallow Copy

            //Arr02 = Arr01; // Shallow Copy
            //               // Copy Value of Arr01 To Arr02
            //               // Copy Addresses - Happened in Stack
            //               // [Arr01 - Arr02] => Have Same Value
            //               // [Arr01 - Arr02] => Refer to same object

            //Console.WriteLine("After Shallow"); 
            //Console.WriteLine($"Hash code of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash code of Arr01 = {Arr02.GetHashCode()}");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr01[0] = 100;

            //Console.WriteLine("After Changing");
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");
            #endregion

            #region Deep Copy
            //Arr02 = (int[])Arr01.Clone(); // Deep Copy
            //                              // Happened in Heap
            //                              // Create New Object with Different and new Identity then return it
            //                              // the new object will have the same object state [data] of Caller [Arr01]

            //Console.WriteLine("After DDeep Copy");
            //Console.WriteLine($"Hash code of Arr01 = {Arr01.GetHashCode()}");
            //Console.WriteLine($"Hash code of Arr01 = {Arr02.GetHashCode()}");

            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");

            //Arr01[0] = 100;

            //Console.WriteLine("After Changing");
            //Console.WriteLine($"Arr01[0] = {Arr01[0]}");
            //Console.WriteLine($"Arr02[0] = {Arr02[0]}");
            #endregion
            #endregion

            #region Array of Reference Type [String]
            //string[] names01 = { "Omar", "Amr" };
            //string[] names02 = new string[2];

            //Console.WriteLine($"Hashcode of Names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of Names02 = {names02.GetHashCode()}");

            #region Shallow Copy
            //names02 = names01; // Shallow Copy
            // Copy Value names01 => names02
            // [names01 - names02] => Have same value
            // [names01 - names02] => Refer to same object

            //Console.WriteLine($"After Shallow Copy");
            //Console.WriteLine($"Hashcode of Names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of Names02 = {names02.GetHashCode()}");

            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            //names01[0] = "Salma";

            //Console.WriteLine($"After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");
            #endregion

            #region Deep Copy
            //names02 = (string[])names01.Clone();

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hashcode of Names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of Names02 = {names02.GetHashCode()}");

            //names01[0] = "Salma";

            //Console.WriteLine($"After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            #endregion

            #endregion

            #region Array of Reference Type [Stringbuilder]
            //StringBuilder[] names01 = [new StringBuilder("Omar")];
            //StringBuilder[] names02 = new StringBuilder[1];

            //Console.WriteLine($"Hash code of names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"Hash code of names02 = {names02.GetHashCode()}");

            #region Shallow Copy
            //names02 = names01;

            //Console.WriteLine($"After Shallow Copy");
            //Console.WriteLine($"Hashcode of Names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of Names02 = {names02.GetHashCode()}");

            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            //names01[0].Append(" Salma");

            //Console.WriteLine($"After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            #endregion

            #region Deep Copy
            //names02 = (StringBuilder[])names01.Clone();

            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine($"Hashcode of Names01 = {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode of Names02 = {names02.GetHashCode()}");

            //names01[0].Append(" Salma");

            //Console.WriteLine($"After Changing");
            //Console.WriteLine($"names01[0] = {names01[0]}");
            //Console.WriteLine($"names02[0] = {names02[0]}");

            #endregion
            #endregion
            #endregion

            #region Built In Interfaces

            #region ICloneable
            //Employee employee01 = new Employee() { Id = 10, Name = "Omar", Salary = 5000 };
            //Employee employee02 = new Employee() { Id = 20, Name = "Mona", Salary = 8000 };

            //Console.WriteLine(employee01);
            //Console.WriteLine($"Employee01 Has Code is {employee01.GetHashCode()}");

            //Console.WriteLine(employee02);
            //Console.WriteLine($"Employee02 Has Code is {employee02.GetHashCode()}");

            //employee02 = (Employee)employee02.Clone();

            //employee02 = new Employee()
            //{
            //    Id = employee01.Id,
            //    Name = employee01.Name,
            //    Salary = employee01.Salary,
            //};

            //employee02 = new Employee(employee01);
            //Console.WriteLine("After Deep Copy");
            //Console.WriteLine(employee01);
            //Console.WriteLine($"Employee01 Has Code is {employee01.GetHashCode()}");

            //Console.WriteLine(employee02);
            //Console.WriteLine($"Employee02 Has Code is {employee02.GetHashCode()}");
            #endregion

            #region ICompareable
            //int[] numbers = { 4, 5, 6, 9, 1, 2, 7, 5 };

            //Array.Sort(numbers); // Static Method calling with Class Name

            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Employee[] employees =
            //{
            //    new Employee() {Id = 10, Name = "Omar", Salary = 6000},
            //    new Employee() {Id = 20, Name = "Ahmed", Salary = 10000},
            //    new Employee() {Id = 30, Name = "Sama", Salary = 4000},
            //    new Employee() {Id = 40, Name = "May", Salary = 5000},
            //};

            //Array.Sort(employees);
            //Array.Reverse(employees);

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion



            #endregion


        }
    }
}
