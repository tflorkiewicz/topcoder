using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRM145._250
{
    class Bonuses
    {
        public static void Main()
        {
            var b = new Bonuses();
            var r = b.getDivision(new int[]
            {
                1,
                2,
                3,
                4,
                5
            }
        );
            foreach (var i in r)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        public int[] getDivision(int[] points)
        {
            var totalPoints = points.Sum();
            var result = new int[points.Length];
            decimal remainder = 0.0m;
            var idx = 0;

            foreach (var i in points)
            {
                
                var percent = (int)((i*1.0/totalPoints)*100);
                decimal x1 = (i*1.0m/totalPoints);

                //remainder += ((decimal)i / totalPoints) * 100 - percent;
                remainder += x1*100m - (int)(x1*100);
                
                result[idx] = percent;
                ++idx;
            }

            int[] tmp = new int[points.Length];
            Array.Copy(result.ToArray(),0, tmp,0,points.Length);

            for (var i = 0; i <= remainder; i++)
            {
                var x = tmp.Max();
                for (int j = 0; j < points.Length; j++)
                {
                    if (result[j] == x)
                    {
                        result[j]++;
                        tmp[j] = 0;
                    }
                    
                }

            }
            
            return result;
        }

    }
}
