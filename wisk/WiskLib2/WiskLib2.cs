using System;

namespace WiskLib2
{
    public class WiskLib2
    {
        public static int Sq(int x)
        {
            return x * x;
        }

        public static int Constrain(int value, int low, int high)
        {

            if (value < low)
            {
                return low;
            }
            else if(value > high)
            {
                return high;
            }
            else
            {
                return value;
            }
            
        


        }
    }
}
