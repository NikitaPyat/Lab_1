using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lab_1
{
    public class Lab_1_main
    {
        static void Main(string[] args)
        {
            Grid2D point = new Grid2D(100, 100, 18, 18);

            Console.WriteLine("\nPoint 1\n");
            V5DataOnGrid a = new V5DataOnGrid("Pyatakov Nikita", DateTime.Now, point);
            Console.WriteLine("\n");
            a.InitRandom(2, 15);
            Console.WriteLine(a.ToLongString());
            V5DataCollection b = (V5DataCollection)a;
            Console.WriteLine(b.ToLongString());

            Console.WriteLine("\nPoint 2\n");
            V5MainCollection c = new V5MainCollection();
            c.AddDefaults();
            Console.WriteLine(c.ToString());

            Console.WriteLine("\nPoint 3\n");
            Vector2[] array;
            foreach (V5Data obj in c)
            {
                array = obj.NearEqual(2);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("[" + array[i].X + ", " + array[i].Y + "]");
                }
            }
            Console.ReadKey();
        }
    }
}
