using System;
using System.Collections.Generic;


    public class Bonuses
    {
        public static void Main()
        {
            Bonuses b = new Bonuses();
            int[] r = b.getDivision(new int[]
            {485, 324, 263, 143, 470, 292, 304, 188, 100, 254, 296,
 255, 360, 231, 311, 275,  93, 463, 115, 366, 197, 470}
        );
            foreach (int i in r)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public int[] getDivision(int[] points)
        {
            int totalPoints = Sum(points);
            int[] result = new int[points.Length];
            decimal remainder = 0m;
            int idx = 0;

            foreach (int i in points)
            {
                
                int percent = (int)(((i*1m)/totalPoints)*100m);
                decimal x1 = (i*1m)/totalPoints;
                remainder += x1*100m - (int)(x1*100m);
                result[idx] = percent;
                ++idx;
            }

            int[] tmp = new int[points.Length];
            Array.Copy(result,0, tmp,0,points.Length);
            remainder = Math.Round(remainder, 4);

            for (int i = 0; i < remainder; i++)
            {
                int? x = Max(tmp);
                for (int j = 0; j < points.Length; j++)
                {
                    if (result[j] == x)
                    {
                        result[j]++;
                        tmp[j] = 0;
                        j = points.Length;
                    }
                }
            }
            return result;
        }

        private int Sum(IEnumerable<int> a)
        {
            int result = 0;
            foreach (int i in a)
            {
                result += i;
            }
            return result;
        }

        private int? Max(int[] a)
        {
            if (a.Length == 0)
                return 0;

            int result = a[0];
            foreach (int i in a)
            {
                if (i > result)
                    result = i;
            }
            return result;
        }


    }
