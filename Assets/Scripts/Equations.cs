public namespace Equations
{
    static public class Equations
    {
        static double Quadratic(double x, double a=1, double b=0, double c=0)
        {
            return a*x*x + b*x + c;
        }

        static double Linear(double x, double a=1, double b=0)
        {
            return a*x + b;
        }

        

    }
}