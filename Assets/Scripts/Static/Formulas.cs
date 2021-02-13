namespace Static
{

    static class Formulas
    {

        static public float Lienar(float x, float a=1, float b=0)
        {
            return a*x + b;
        }

        static public float Quadratic(float x, float a=1, float b=0, float c = 0)
        {
            return a*x*x + Lienar(x, b, c);
        }

        static public float Cubic(float x, float a=1, float b=0, float c=0, float d=0)
        {
            return a*x*x*x + Quadratic(x, b, c, d);
        }

    }

}