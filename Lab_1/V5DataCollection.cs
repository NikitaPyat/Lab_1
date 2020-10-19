using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab_1
{
    public class V5DataCollection : V5Data
    {
        public Dictionary<Vector2, Vector2> dic { get; set; }
        public V5DataCollection(string s, DateTime t) : base(s, t)
        {
            dic = new Dictionary<Vector2, Vector2>();
        }

        public void InitRandom(int nItems, float xmax, float ymax, float minValue, float maxValue)
        {
            Random r = new Random();
            float x, y, data_x, data_y;
            Vector2 point, value;
            for (int i = 0; i < nItems; i++){

                x = (float)r.NextDouble();
                y = (float)r.NextDouble();
                data_x = (float)r.NextDouble();
                data_y = (float)r.NextDouble();
                data_x = minValue + (maxValue - minValue) * data_x;
                data_y = minValue + (maxValue - minValue) * data_y;
                x = xmax * x;
                y = ymax * y;
                point = new Vector2(x, y);
                value = new Vector2(data_x, data_y);
                dic.Add(point, value);
            }
        }

        public override Vector2[] NearEqual(float eps)
        {
            List<Vector2> vec = new List<Vector2>();
            foreach (KeyValuePair<Vector2, Vector2> keys in dic)
            {
                Vector2 zn = keys.Value;
                if (Math.Abs(zn.X - zn.Y) <= eps)
                    vec.Add(zn);
            }
            Vector2[] res = vec.ToArray();
            return res;
        }

        public override string ToLongString()
        {
            string str = "V5DataCollection\n";
            str += info + " " + data.ToString() + "\nNumber of elements: " + dic.Count + "\n";
            foreach (KeyValuePair<Vector2, Vector2> key in dic)
            {
                str += key.Key + " " + key.Value + "\n";
            }
            return str;
        }

        public override string ToString()
        {
            return "Info\n" +  info + " " + data.ToString() + "\nCount of elements: " + dic.Count + "\n";
        }
    }
}
