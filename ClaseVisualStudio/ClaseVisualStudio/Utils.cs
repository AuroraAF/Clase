﻿namespace ClaseVisualStudio
{
    class Utils
    {
        public static int GetMinValue(int a, int b)
        {
            if (a < b)
           return a;
            
            else 
                return b;
            
        }
        public static int GetMaxValue(int c, int d)
        {
            if (c > d)
                return c;
            else
                return d;
        }

        public static bool IsEven(int value)
        {
            if ((value % 2) == 0)
                return true;

                return false;
        }

    } 

}
