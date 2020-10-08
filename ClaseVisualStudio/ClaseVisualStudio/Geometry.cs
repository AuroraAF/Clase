using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ClaseVisualStudio
{
    class Geometry
    {
        public static double GetVector2DLength(double x, double y)
        {
            double aux;
            double length;

            aux = x * x + y * y;

            length = System.Math.Sqrt(aux);
            return length;

        }

        public static double GetVector3DLength(double x, double y, double z)
        {
            double aux3;
            double length3;

            aux3 = x * x + y * y + z * z;

            length3 = System.Math.Sqrt(aux3);
            return length3;
        }

        public static double GetCircleArea(double radio)
        {
            double pi;
            double sol;
            pi = System.Math.PI;
            sol = pi * (radio * radio);

            return sol;
        }

        public static double GetRectangleArea(double width, double height)
        {
            double sol;

            sol = width * height;

            return sol;
        }

        public static double GetEllipseArea(double radius1, double radius2)
        {
            double pi;
            double sol;
            pi = System.Math.PI;
            sol = pi * radius1 * radius2;

            return sol;
        }
            
        
                
         
    }
}
