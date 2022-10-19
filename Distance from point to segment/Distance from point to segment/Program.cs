using System;

namespace DistanceTask
{
    public static class GetDistance
    {
        static void Main()
        {
            Console.WriteLine(GetDistanceToSegment(-1, 2, -1, 2, 1, -2));
        }
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            double triangleArea = 0.5 * ((ax - x) * (by - y) - (bx - x) * (ay - y));
            double distanceFromAToB = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            double distance = Math.Abs((triangleArea / distanceFromAToB) * 2);
            double distanceFromAToC = Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay));
            double distanceFromBToC = Math.Sqrt((x - bx) * (x - bx) + (y - by) * (y - by));
            if (distanceFromAToC * distanceFromAToC > distanceFromBToC * distanceFromBToC + distanceFromAToB * distanceFromAToB)
                return distanceFromBToC;
            if (distanceFromBToC * distanceFromBToC > distanceFromAToC * distanceFromAToC + distanceFromAToB * distanceFromAToB)
                return distanceFromAToC;
            if (triangleArea == 0)
            {
                if ((x - ax) * (by - ay) - (bx - ax) * (y - ay) == 0 && (distanceFromAToB != 0))
                    return 0;
                else
                    return Math.Min(distanceFromAToC, distanceFromBToC);
            }
            return distance;
        }


    }
}
