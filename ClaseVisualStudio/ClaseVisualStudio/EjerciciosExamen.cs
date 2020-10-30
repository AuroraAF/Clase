using System.IO;

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
        public static void PrintError(int code)
        {
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error grave");
                    break;
                case 1:
                    System.Console.WriteLine("Error moderado");
                    break;
                case 2:
                    System.Console.WriteLine("Error leve");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido");
                    break;

            }
        }
        public static void PrintNumber(int n)
        {
            int i = 0;

            while (i <= n)
            {
                System.Console.Write(i + ",");
                i += 3;
            }
        }
        public static void PrintNumber2(int f)
        {
            for (int i = 0; i <= f; i++)
            
                System.Console.Write(i + ",");
            
        }
        public static void PrintNumber3(int f3)
        {
            for (int i = 0; i <= f3; i++) 
            {
                System.Console.Write(i);
                if (i < f3)
                    System.Console.Write(",");
            }
               
        }
        public static void PrintLine(int l)
        {
            for (int i = 0; i < l; i++)
            {
                System.Console.Write("*");
            }
        }
        public static void PrintSymbol(int ps)
        {
            for (int i = 0; i < ps; i++)
            {
                if (i % 2 == 0)
                    System.Console.Write("+");
                else
                    System.Console.Write("*");
            }
        }
        public static void PrintSymbol2(int ps2)
        {
            for (int i = 0; i < ps2; i++)
            {
                int resto = i % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("-");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("*");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }
            }
            
        }



       


        

    }
}
