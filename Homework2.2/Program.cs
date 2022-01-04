using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double PointsIT = 99.9;           // Баллы по программированию А
            double PointsMaths = 49.9;        // Баллы по математике  B
            double PointsPhysics = 39.5;      // Баллы по физике      C



            double valueA = 99.9; double valueB = 49.9; double valueC = 39.5;
            double valueD = valueA + valueB + valueC;                                 // Сумма Баллов  D=189.3
            Console.WriteLine(valueD);                                           
            Console.ReadKey();

            double valueF = (valueA + valueB + valueC) / 3;                            // среднее арифметическое баллов F=63.1
            Console.WriteLine(valueF);         
            Console.ReadKey();
        }
    }
}
