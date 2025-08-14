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

            #region Built In Interface

            #endregion


        }
    }
}
