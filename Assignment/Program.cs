using Assignment.First_Project;
using Assignment.Second_Project;
using Assignment.Third_Project.Discounts;
using Assignment.Third_Project.Users;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Math = Assignment.Second_Project.Math;

namespace Assignment
{
    internal class Program
    {
        static int ReadCoordinate(string coordinateName)
        {
            int value;
            while (true)
            {
                Console.Write($"Enter: {coordinateName}: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out value))
                    break;

                else
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return value;
        }
        static void Main(string[] args)
        {
            #region First Project
            // 1. Define 3D Point Class and the basic Constructors (use chaining in constructors).

            // 2.Override the ToString Function to produce this output:
            // Point3D P = new Point3D(10, 10, 10);
            // Console.WriteLine(P.ToString());
            // Output: “Point Coordinates: (10, 10, 10)”.

            // 3. Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            // 4.	Try to use  ==
            // If(P1 == P2)   Does it work properly?

            // 5. Define an array of points and sort this array based on X & Y coordinates. 

            // 6. Implement ICloneable interface to be able to clone the object.

            //Point3D point3D = new Point3D(10, 10, 10);
            //Console.WriteLine(point3D);

            //Console.WriteLine("Enter Coordinates for Point 01: ");
            //int X1 = ReadCoordinate("X1");
            //int Y1 = ReadCoordinate("Y2");
            //int Z1 = ReadCoordinate("Z3");
            //Point3D P01 = new Point3D(X1, Y1, Z1);

            //Console.WriteLine("Enter coordinates for Point 02: ");
            //int X2 = ReadCoordinate("X2");
            //int Y2 = ReadCoordinate("Y2");
            //int Z2 = ReadCoordinate("Z2");
            //Point3D P02 = new Point3D(X2, Y2, Z2);

            //Console.WriteLine($"P01 == P02? {P01 == P02}");

            //Point3D[] points = new Point3D[]
            //{
            //    new Point3D(3,5,0),
            //    new Point3D(1,7,2),
            //    new Point3D(1,2,9),
            //    new Point3D(3,1,4),
            //    P01, P02
            //};

            //Array.Sort(points);
            //Console.WriteLine("\nSorted Points: ");
            //foreach (Point3D point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //Point3D cloneP01 = (Point3D)P01.Clone();
            //Console.WriteLine($"\nCloned P01: {cloneP01}");

            #endregion

            #region Second Project:
            // Define Class Maths that has four methods:
            // ● Add()
            // ● Subtract()
            // ● Multiply()
            // ● Divide()
            // Each of them takes two parameters. Call each method in Main().
            // NOTE : Modify the program so that you do not have to create an instance of
            // class to call the four methods.

            //Console.WriteLine(Math.Add(10, 15));
            //Console.WriteLine(Math.Subtract(15, 10));
            //Console.WriteLine(Math.Multiply(10, 15));
            //Console.WriteLine(Math.Divide(15, 0));
            //Console.WriteLine(Math.Divide(15, 5));

            #endregion

            #region Third Project
            /*
             * You are tasked with designing a system for an e-commerce platform that calculates discounts for 
             * different types of users and products.
             * This system should utilize abstraction and include the following parts:
             * Part 1: Abstract Discount Class
             * Create an abstract class Discount with:
             * o An abstract method CalculateDiscount(decimal price, int quantity) that returns the 
             * discount amount based on the original price and quantity.
             * o A Name property to store the type of discount.
             * Part 2: Specific Discounts
             * Implement the following concrete discount classes:
             * o PercentageDiscount:
             * ▪ Accepts a percentage (e.g., 10%).
             * ▪ Formula: Discount Amount=Price×Quantity×(Percentage/100)
             * o FlatDiscount:
             * ▪ Accepts a fixed amount to be deducted (e.g., $50).
             * ▪ Formula: Discount Amount=Flat Amount×min(Quantity,1)
             * o BuyOneGetOneDiscount:
             * ▪ Applies a 50% discount if the quantity is greater than 1.
             * ▪ Formula: Discount Amount=(Price/2)×(Quantity÷2)
             * Part 3: Discount Applicability
             * Create an abstract class User with:
             * o A Name property to store the user name.
             * o An abstract method GetDiscount() that returns a Discount object.
             * Implement the following specific user types:
             * o RegularUser: Applies a PercentageDiscount of 5%.
             * o PremiumUser: Applies a FlatDiscount of $100.
             * o GuestUser: No discount is applied
             * Part 4: Integration
             * Write a program that:
             * o Ask  the user to input their type (Regular, Premium, or Guest).
             * o Allows the user to input product details (price and quantity).
             * o Calculates and displays the total discount and final price after applying the 
             * appropriate discount.
            */

            //Console.Write("Enter your Name: - ");
            //string? name = Console.ReadLine();

            //Console.Write("Enter user type (Regular / Premium / Guest): ");
            //string? userType = Console.ReadLine()?.Trim().ToLower();

            //User user;

            //switch(userType)
            //{
            //    case "regular":
            //        user = new RegularUser(name);
            //        break;
            //    case "premium":
            //        user = new PremiumUser(name);
            //        break;
            //    case "guest":
            //        user = new GuestUser(name);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid user type. Defaulting to Guest.");
            //        user = new GuestUser(name);
            //        break;
            //}

            //Console.Write("Enter product price: ");
            //decimal price;
            //decimal.TryParse(Console.ReadLine(), out price);

            //Console.Write("Enter quantity: ");
            //int quantity;
            //int.TryParse(Console.ReadLine(), out quantity);

            //Discount discount = user.GetDiscount();
            //decimal discountAmount = discount.CalcDiscount(price, quantity);
            //decimal finalPrice = (price * quantity) - discountAmount;

            //Console.WriteLine($"\nUser: {user.Name} ({userType})");
            //Console.WriteLine($"Discount Type: {discount.Name}");
            //Console.WriteLine($"Discount Amount: {discountAmount:C}");
            //Console.WriteLine($"Final Price: {finalPrice:C}");
            #endregion
        }
    }
}
