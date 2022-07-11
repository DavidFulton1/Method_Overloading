using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    internal class Methods
    {
        public static int Add(int x, int y)
        {
            int answer = x + y;
            return answer;
        }
        public static decimal Add(decimal x, decimal y)
        {
            decimal answer = x + y;
            return answer;
        }
        public static string? Add(int x, int y, bool m)
        {
            int sum = x + y;
            if (m == true && sum > 1)
            {
                string answer = $"{sum} dollars";
                return answer;
            }
            else if (m == true && sum < 2)
            {
                string answer = $"{sum} dollar";
                return answer;
            }
            else return sum.ToString();
        }
    }
}








