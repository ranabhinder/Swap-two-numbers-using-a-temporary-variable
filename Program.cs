using System;

namespace Swap_two_numbers_using_a_temporary_variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Please enter the number for num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number for num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping num1 {0} and num2 {1}", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping num1 {0} and num2 {1}", num1, num2);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();


        }
    }
}
