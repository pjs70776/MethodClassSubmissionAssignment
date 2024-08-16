using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();

            //method 1, 2 inputs
            Console.WriteLine("Enter first mandatory integer here:");
            int additon = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter second mandatory integer here:");
            int secondInteger = Convert.ToInt32(Console.ReadLine());

            //try catch statement
            try
            {
                int additon2 = Convert.ToInt32(Console.ReadLine());
                int sum2 = c1.method1(additon);
                Console.WriteLine(sum2 + " is the answer.");
            }
            catch (Exception ex)
            {
                int additon2 = Convert.ToInt32(Console.ReadLine());
                int sum2 = c1.method1(additon);
                int sum3 = c1.method2(secondInteger);
                Console.WriteLine(sum2 + " is the answer. And " + sum3 + " is the second integer.");
            }
            Console.ReadLine();


        }
    }
}
