using System;

namespace PRN_SE1623_PRO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x = 10, y = 20;
            string name;
            var salary = 10.5;//goi toi APIs (xml/json)
            dynamic fullName = 10;

            int age = int.Parse("30");


            Console.WriteLine(salary.GetType());

            Console.WriteLine($"sum of a ={x} and b ={y} is {Sum(x, y)}");
        }

        public static int Sum(int a, int b)
        {
            return a +b;
        }

    }
}
