using System;

namespace ClaseVisualStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int sol;
            sol = Utils.GetMinValue(10, 7);

            int sol1;
            sol1 = Utils.GetMaxValue(3, 5);

            bool sol2;
            sol2 = Utils.IsEven(9);

            Ejercicios.Ejercicio1();
            */
            int s = EjerciciosExamen.Add(1, 2);
            System.Console.WriteLine(s);

            float m = EjerciciosExamen.SubReales(20, 5);
            System.Console.WriteLine(m);

            EjerciciosExamen.Cat("Hola", "Juan", "casa");

            EjerciciosExamen.EsMenor(8, 7);

            EjerciciosExamen.PrintSymbol(3);
        }
    }
}
