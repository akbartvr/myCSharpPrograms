using System;

namespace basic_CSharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Aliakbar";
            string family = "Tavangar";
            string fullName = name + family;
            Console.WriteLine(fullName);

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("please enter first number:");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter second number:");
            int second = Convert.ToInt32(Console.ReadLine());
            int sum = first + second;
            Console.WriteLine("the sum is : "+sum);

            bool isAliakbarHardWorking = Convert.ToBoolean("True");
            bool isAliakbarIncapable = Convert.ToBoolean("False");
            Console.ReadKey();

        }
    }
}
