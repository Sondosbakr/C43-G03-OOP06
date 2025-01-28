
using Assignment06OOP.SecondProject;
using Assignment06OOP.ThirdProject;
using System;

namespace Assignment06OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project
            //Point3D p1 = ReadPoint("P1");
            //Point3D p2 = ReadPoint("P2");

            //if (p1 == p2)
            //    Console.WriteLine("P1 Equals P2");
            //else
            //    Console.WriteLine("P1 Not Equal P2");

            //Console.WriteLine("------------------------------");

            //Console.WriteLine("Sorted Array");
            //Point3D[] points = { p1, p2, new Point3D(10, 20, 30), new Point3D(5, 10, 15) };
            //Array.Sort(points);
            //foreach (Point3D point in points)
            //    Console.WriteLine(point);

            //Console.WriteLine("--------------------------------");

            //Console.WriteLine("Cloned Object");
            //p2 = (Point3D)p1.Clone();
            //Console.WriteLine(p2);

            #endregion

            #region SecondProject
            //Console.WriteLine(Maths.Add(10, 5));
            //Console.WriteLine(Maths.Subtract(10, 5));
            //Console.WriteLine(Maths.Multiply(10, 5));
            //try 
            //{
            //    Console.WriteLine(Maths.devide(10, 5));
            //    Console.WriteLine(Maths.devide(10,0));
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region ThirdProject
            Console.WriteLine("Please input the type (Regular, Premium, or Guest)");
            string userType = Console.ReadLine().Trim().ToLower();

            User user;
            if (userType == "regular")
                user = new RegularUser("RegularUser");
            else if (userType == "premium")
                user = new PremiumUser("PremiumUser");
            else if (userType == "guest")
                user = new GuestUser("GuestUser");
            else
            {
                Console.WriteLine("Invalid User Type");
                return;
            }

            Console.WriteLine("Enter the product price");
            decimal.TryParse(Console.ReadLine(), out decimal price);
            Console.WriteLine("Enter the product quantity");
            int.TryParse(Console.ReadLine(), out int quantity);


            Discount discount = user.GetDiscount();
            decimal discountAmount = 0;
            if (discount != null)
            {
                discountAmount = discount.CalculateDiscount(price, quantity);
                Console.WriteLine($"Discount Type: {discount.Name}");
                Console.WriteLine($"Total Discount: {discountAmount:C}");
            }
            decimal totalPrice = price * quantity;
            decimal finalPrice = totalPrice - discountAmount;

            Console.WriteLine($"Total Price: {totalPrice:C}");
            Console.WriteLine($"Final Price: {finalPrice:C}");
            #endregion
        }

        #region First Project
        public static Point3D ReadPoint(string pointName)
        {
            int x, y, z;
            while (true)
            {
                Console.WriteLine($"Enter X Y Z Coordinators for {pointName}");
                string[] input = Console.ReadLine().Split();
                if (input.Length == 3 &&
                int.TryParse(input[0], out x) &&
                int.TryParse(input[1], out y) &&
                int.TryParse(input[2], out z))
                {
                    return new Point3D(x, y, z);
                }
                Console.WriteLine("Invalid input. Please use the format 'x y z'.");
            }
        }
        #endregion



    }

    
}
