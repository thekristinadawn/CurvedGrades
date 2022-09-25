using System;

namespace CurvedGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalPoints, PointsStudent1, PointsStudent2, PointsStudent3, PointsStudent4, PointsStudent5;

            //collecting students scores
            Console.WriteLine("Total Points of Assignment");
            totalPoints = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student 1 Score");
            PointsStudent1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student 2 Score");
            PointsStudent2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student 3 Score");
            PointsStudent3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student 4 Score");
            PointsStudent4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Student 5 Score");
            PointsStudent5 = Convert.ToInt32(Console.ReadLine());

            double percentStudent1, percentStudent2, percentStudent3, percentStudent4, percentStudent5;

            percentStudent1 = (double)(PointsStudent1 * 100) / totalPoints;
            percentStudent2 = (double)(PointsStudent2 * 100) / totalPoints;
            percentStudent3 = (double)(PointsStudent3 * 100) / totalPoints;
            percentStudent4 = (double)(PointsStudent4 * 100) / totalPoints;
            percentStudent5 = (double)(PointsStudent5 * 100) / totalPoints;

            //Console.WriteLine(percentage);
            int maxCheck, maxScore, curvePoints, curvedPoints1, curvedPoints2, curvedPoints3, curvedPoints4, curvedPoints5;
            maxCheck = Math.Max(Math.Max(PointsStudent1, PointsStudent2), PointsStudent3);
            maxScore = Math.Max(Math.Max(maxCheck, PointsStudent4), PointsStudent5);
            curvePoints = (totalPoints - maxScore);
            curvedPoints1 = (PointsStudent1 - curvePoints);
            curvedPoints2 = (PointsStudent2 - curvePoints);
            curvedPoints3 = (PointsStudent3 - curvePoints);
            curvedPoints4 = (PointsStudent4 - curvePoints);
            curvedPoints5 = (PointsStudent5 - curvePoints);

            double percentCurved1, percentCurved2, percentCurved3, percentCurved4, percentCurved5;

            percentCurved1 = (double)(curvedPoints1 * 100) / totalPoints;
            percentCurved2 = (double)(curvedPoints2 * 100) / totalPoints;
            percentCurved3 = (double)(curvedPoints3 * 100) / totalPoints;
            percentCurved4 = (double)(curvedPoints4 * 100) / totalPoints;
            percentCurved5 = (double)(curvedPoints5 * 100) / totalPoints;

            int sumCurvedAverage = (curvedPoints1 + curvedPoints2 + curvedPoints3 + curvedPoints4 + curvedPoints5) / 5;


            //string percentage = string.Format("{0}%\n", percent);
            //Console.WriteLine(percentage);

            //show table

            string row = ("-----------------------------------------------------------------------------------------------------------");
            string space = "      ";
            string endSpace = "         |";
            string lastSpace = "         |";
            Console.WriteLine(row);
            Console.WriteLine("|              | Uncurved Points  |   Uncurved %    | Curved Points   |    Curved %     |   Above/Below   |");
            Console.WriteLine("|              |                  |                 |                 |                 |  Curve Average  |");
            Console.WriteLine(row);
            Console.WriteLine("|  Student 1   | " + space + PointsStudent1 + endSpace + space + percentStudent1 + endSpace + space + curvedPoints1 + endSpace + space + percentCurved1 + endSpace + space + sumCurvedAverage + lastSpace);
            Console.WriteLine(row);
            Console.WriteLine("|  Student 2   | " + space + PointsStudent2 + endSpace + space + percentStudent2 + endSpace + space + curvedPoints2 + endSpace + space + percentCurved2 + endSpace + space + sumCurvedAverage + lastSpace);
            Console.WriteLine(row);
            Console.WriteLine("|  Student 3   | " + space + PointsStudent3 + endSpace + space + percentStudent3 + endSpace + space + curvedPoints3 + endSpace + space + percentCurved3 + endSpace + space + sumCurvedAverage + lastSpace);
            Console.WriteLine(row);
            Console.WriteLine("|  Student 4   | " + space + PointsStudent4 + endSpace + space + percentStudent4 + endSpace + space + curvedPoints4 + endSpace + space + percentCurved4 + endSpace + space + sumCurvedAverage + lastSpace);
            Console.WriteLine(row);
            Console.WriteLine("|  Student 5   | " + space + PointsStudent5 + endSpace + space + percentStudent5 + endSpace + space + curvedPoints5 + endSpace + space + percentCurved5 + endSpace + space + sumCurvedAverage + lastSpace);
            Console.WriteLine(row);





        }
    }
}
