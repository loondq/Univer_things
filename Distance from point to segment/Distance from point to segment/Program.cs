using System;

namespace DistanceTask
{
    public static class DistanceTask
    {
        static void Main()
        {
            Console.WriteLine(GetDistanceToSegment(1, 1, 1, 1, 1, 1));
        }
        public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
        {
            double[] distancesFromPointToPoint = GetDistanceFromPointToPoint(ax, ay, bx, by, x, y);
            double triangleArea = 0.5 * ((ax - x) * (by - y) - (bx - x) * (ay - y));
            double distance = Math.Abs((triangleArea / distancesFromPointToPoint[0]) * 2);
            if (IsObtuseAngle(distancesFromPointToPoint[0], distancesFromPointToPoint[1], distancesFromPointToPoint[2])[0])
                return distancesFromPointToPoint[2];
            if (IsObtuseAngle(distancesFromPointToPoint[0], distancesFromPointToPoint[1], distancesFromPointToPoint[2])[1])
                return distancesFromPointToPoint[1];
            if (triangleArea == 0)
            {
                if ((x - ax) * (by - ay) - (bx - ax) * (y - ay) == 0 && (distancesFromPointToPoint[0] != 0))
                    return 0;
                return Math.Min(distancesFromPointToPoint[1], distancesFromPointToPoint[2]);
            }
            return distance;
        }
        /// <returns>1. A to B | 2. A to C | 3. B to C</returns>
        static double[] GetDistanceFromPointToPoint(double ax, double ay, double bx, double by, double x, double y)
        {
            double[] distances = new double[3];
            distances[0] = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            distances[1] = Math.Sqrt((x - ax) * (x - ax) + (y - ay) * (y - ay));
            distances[2] = Math.Sqrt((x - bx) * (x - bx) + (y - by) * (y - by));
            return distances;
        }
        /// <returns>1. тупой угол ABC | 2. тупой угол BAC</returns>
        static bool[] IsObtuseAngle(double aToB, double aToC, double bToC)
        {
            bool[] obtuseAngles = { false, false };
            if (aToC * aToC > bToC * bToC + aToB * aToB)
                obtuseAngles[0] = true;
            if (bToC * bToC > aToC * aToC + aToB * aToB)
                obtuseAngles[1] = true;
            return obtuseAngles;
        }
    }
}
