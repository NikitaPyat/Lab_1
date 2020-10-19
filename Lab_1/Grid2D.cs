using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class Grid2D
    {
        public float x_step { get; set; }
        public int x_kol { get; set; }
        public float y_step { get; set; }
        public int y_kol { get; set; }


        public Grid2D(float x1, int x2, float y1, int y2)
        {
            x_step = x1;
            x_kol = x2;
            y_step = y1;
            y_kol = y2;
        }

        public override string ToString()
        {
            return "\nGrid2D:\n" + "Step by x: " + x_step.ToString() + "\n"
                               + "Step's number: " + x_kol.ToString() + "\n"
                               + "Step by y: " + y_step.ToString() + "\n"
                               + "Step's number: " + y_kol.ToString() + "\n";
        }
    }
}
