using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DmitrievLR.Sprint2.Task4.V7.Lib
{
    public class DataService : ISprint2Task4V7
    {
        public double Calculate(double x, double y)
        {
            double z = (x - 10 > y + 2) ?
                Math.Round((1 + Math.Pow((Math.Sqrt(x + 3) / x), y)), 3) :
                Math.Round((Math.Pow(x, 3) + 2 * x + (6 + Math.Pow(y, -4))), 3);


            return z;

        }
    }
}
