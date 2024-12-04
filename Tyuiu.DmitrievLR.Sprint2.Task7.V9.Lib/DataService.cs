using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DmitrievLR.Sprint2.Task7.V9.Lib
{
    public class DataService : ISprint2Task7V9
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool isInArea = y >= 0 && y <= 0.5 && Math.Sin(x) >= y;

            bool res;

            if (isInArea)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            
            return res;
        }
    }
}
