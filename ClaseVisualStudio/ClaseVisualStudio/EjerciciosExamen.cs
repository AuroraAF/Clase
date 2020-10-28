namespace ClaseVisualStudio
{
    class EjerciciosExamen
    {
        public static int Add(int a, int b)
        {
            int result;
            result = a + b;
            return result;
        }
        public static float SubReales(float a, float b)
        {
            float result;
            result = a - b;
            return result;
        }
        public static double Menor(double a, double b)
        {
            a = 7;
            b = 15;
            double result;
            if (a < b)
            {
                result = a;
            }
            else
            {
                result = b;
            }
            return result;


        }
        public static string Cat(string a, string b, string c)
        {
            return a + b + c;
        }
        public static bool EsMenor(int a, int b)
        {

            if (a < b)
                return true;
            else
                return false;


        }
        public static int Comparar(int a, int b)
        {
            if (a < b)
                return -1;
            
            else if (a > b)
                return 1;
            
            else
                return 0;

        }
        public static double Cuadrado(double a, double b)
        {
            if (a < b)
                return b * b;
            else
                return 2.0 * a + b;
        }



       


        

    }
}
