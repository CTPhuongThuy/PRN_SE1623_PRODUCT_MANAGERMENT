using System;
using static System.Console;
using System.Collections;

namespace PRN_SE1623_OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*define a collection employees*/
            ArrayList lstEmps = new ArrayList();

            // lstEmps.Add(new Employee(1, "dong", 123, new Address(125,"WArd","Phuong3","quan 10","HCM")));
            //lstEmps.Add(new Employee(2, "dong", 123));
            //Display(lstEmps);


            /*abstract*/

            WriteLine("=================");
            Shape s = new Crircle(100);//polymorphis
            double area = s.Peremetter();
            WriteLine(area);
            Shape p = new Crircle();
            p.display();

            /*interface*/
            IShape ac = new Rectangle();



            ReadLine();


        }
        private static void Display(ArrayList lstData)
        {
            //foreach (Employee e in lstData)
            //{
            //    WriteLine();

            //}
            for (int i = 0; i < lstData.Count; i++)
            {
                WriteLine(lstData[i]);
            }
        }

    }
}
