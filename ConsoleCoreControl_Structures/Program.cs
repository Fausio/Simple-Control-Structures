using System;

namespace ConsoleCoreControl_Structures
{
    class Program
    {
        static void Main(string[] args)
        {

            #region simple if statement 
            //int a, b;
            //a = 10;
            //b = 20;

            //if (a > b)
            //{
            //    Console.WriteLine("{0} is Greater", a);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is Greater", b);
            //}
            #endregion
            #region if statment 
            //int a = 10;
            //int b = 20;
            //int c = 6;
            //int d = 56;

            //if (a > b && a > c && a > d)
            //{
            //    Console.WriteLine("{0} is Greater", a);
            //}
            //else
            //{
            //    if (b > a && b > c && b > d)
            //    {
            //        Console.WriteLine("{0} is Greater", b);
            //    }
            //    else
            //    {
            //        if (c > a && c > b && c > d)
            //        {
            //            Console.WriteLine("{0} is Greater", c);
            //        }
            //        else
            //        {
            //            Console.WriteLine("{0} is Greater", d);
            //        }
            //    }
            //}
            #endregion
            #region if statment simple to read 
            //int a = 10;
            //int b = 20;
            //int c = 6;
            //int d = 56;

            //if (a > b && a > c && a > d)
            //{
            //    Console.WriteLine("{0} is Greater", a);
            //}
            //else if (b > a && b > c && b > d)
            //{
            //    Console.WriteLine("{0} is Greater", b);
            //}
            //else if (c > b && c > a && c > d)
            //{
            //    Console.WriteLine("{0} is Greater", c);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is Greater", d);
            //}

            #endregion
            #region Switch statement
            int a = 10;
            int b = 20;
            //int exceptionNull = 0;



            Console.WriteLine("1.Add 2.Mul 3.Sub 4 Exit");

            var opt = Int32.Parse(Console.ReadLine());

            switch (opt)
            {
                case 1:
                    Console.WriteLine("addition of {0} end {1} is: " + a + b, a, b);
                    break;
                case 2:
                    Console.WriteLine("Multiplication of {0} end {1} iS: " + a * b, a, b);
                    break;
                case 3:
                    Console.WriteLine("subtraction of {0} end {1} iS: " + (a - b), a, b);
                    break;
                case 4:
                    Console.WriteLine("you are exiting the system...");
                    break;

                default:
                    Console.WriteLine("Invalid option !");
                    break;
            }



            #endregion



            Console.ReadKey();
        }
    }
}
