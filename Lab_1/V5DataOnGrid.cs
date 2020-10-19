using System;
using System.Collections.Generic;
using System.Numerics;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class V5DataOnGrid : V5Data
    {
        public Grid2D net { get; set; }
        public Vector2[,] mas { get; set; }

        public V5DataOnGrid(string s, DateTime d, Grid2D gr) : base(s, d)
        {
            net = gr;
            mas = new Vector2[net.x_kol, net.y_kol];
        }

        public void InitRandom(float minValue, float maxValue)
        {
            float x, y;
            Random r = new Random();

            for(int i = 0; i < net.x_kol; i++){
                for (int j = 0; j < net.y_kol; j++)
                {
                    x = (float)r.NextDouble();
                    y = (float)r.NextDouble();
                    x = minValue + (maxValue - minValue) * x;
                    y = minValue + (maxValue - minValue) * y;
                    mas[i, j] = new Vector2(x, y);
                }
            }

        }

        public static explicit operator V5DataCollection(V5DataOnGrid d){
            V5DataCollection col = new V5DataCollection(d.info, d.data);
            Vector2 key, value;
            for (int i = 0; i < d.net.x_kol; i++)
                for (int j = 0; j < d.net.y_kol; j++)
                {
                    key = new Vector2(i, j);
                    value = new Vector2(d.mas[i, j].X, d.mas[i, j].Y);
                    col.dic.Add(key, value);
                }
            return col;
        }

        public override Vector2[] NearEqual(float eps)
        {
            List<Vector2> v = new List<Vector2>();
            for (int i = 0; i < net.x_kol; i++)
                for (int j = 0; j < net.y_kol; j++)
                    if (Math.Abs(mas[i, j].X - mas[i, j].Y) <= eps)
                        v.Add(mas[i, j]);
            Vector2[] res = v.ToArray();
            return res;
        }

        public override string ToLongString()
        {
            string str = "V5DataOnGrid\n";
            str += info + " " + data.ToString() + " " + net.ToString() + "\n";
            for (int i = 0; i < net.x_kol; i++)
                for (int j = 0; j < net.y_kol; j++)
                {
                    str += "[" + i + ", " + j + "] " + "(" + mas[i, j].X + ", " + mas[i, j].Y + ")\n";
                }
            str += "\n";
            return str;
        }

        public override string ToString()
        {
            return "V5DataOnGrid\n" + info + " " + data.ToString() + " " + net.ToString() + "\n";
        }
    }
}
