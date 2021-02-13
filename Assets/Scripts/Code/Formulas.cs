namespace Graph.Code
{

    static class Formulas
    {

        static public float Quadratic(float x, float a=1, float b=0, float c = 0)
        {
            return a*x*x + b*x + c;
        }

        static public float Lienar(float x, float a=1, float b=0)
        {
            return a*x + b;
        }

    }

}