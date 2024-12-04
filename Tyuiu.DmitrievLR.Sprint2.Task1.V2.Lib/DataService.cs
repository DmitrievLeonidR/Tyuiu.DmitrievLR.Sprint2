using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.DmitrievLR.Sprint2.Task1.V2.Lib
{
    public class DataService : ISprint2Task1V2
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // True
            result[0] = (a < b) && (c < d);

            // True
            result[1] = !(a == b);

            // True
            result[2] = (a <= c) || (b > d);

            // True
            result[3] = (a != c) && (b <= d);

            // True
            result[4] = (c < a) ^ (d >= b);

            // False
            result[5] = (a == d) || (b == c);

            return result;
        }
    }
}
