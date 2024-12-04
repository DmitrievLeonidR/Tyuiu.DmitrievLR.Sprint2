using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DmitrievLR.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            if ((x >= 3 && x <= 5 && y >= 3 && y <= 5) ||
           (x >= 6 && x <= 10 && y >= 4 && y <= 7) ||
           (x >= 8 && x <= 11 && y >= 9 && y <= 11) ||
           (x >= 12 && x <= 15 && y >= 11 && y <= 13))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
