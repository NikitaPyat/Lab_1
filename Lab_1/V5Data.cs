using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public abstract class V5Data
    {
        public string info {get; set;}
        public DateTime data { get; set; }


        public V5Data(string i, DateTime d)
        {
            info = i;
            data = d;
        }
        public abstract Vector2[] NearEqual(float eps);

        public abstract string ToLongString();
        public override string ToString()
        {
            return "Info: " + info + "\n" + "Data: " + data.ToString() + "\n";
        }
    }
}
