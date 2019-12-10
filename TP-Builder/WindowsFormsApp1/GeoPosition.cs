using System;

namespace TPBuilder
{
    public static class GeoPosition
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static string ConvertToDMS(double x, double y)
        {
            double degX = Math.Floor(x);
            double degY = Math.Floor(y);

            double tempDegX = x - degX;
            double tempDegY = y - degY;

            double minX = Math.Abs(tempDegX * 60);
            double minY = Math.Abs(tempDegY * 60);

            Console.WriteLine($"'minX: {minX}, minY:{minY} X: {x}, Y: {y}");
            return null;
        }

        public static string getCoord(int x, int y, int width, int height)
        {
            double degreFromMidX = Math.Abs(x - width / 2);
            double horizontalDegree = (degreFromMidX * 360) / width;
            double horizontalMin = (horizontalDegree - Math.Floor(horizontalDegree)) * 60;

            double degreFromMidY = Math.Abs(y - height / 2);
            double verticalDegree = (degreFromMidY * 360) / width;
            double verticalMin = (verticalDegree - Math.Floor(verticalDegree)) * 60;



            if ((x < width / 2) && (y < height / 2))
                return $"{Math.Floor(verticalDegree)}° {Math.Floor(verticalMin)} S, {Math.Floor(horizontalDegree)}° {Math.Floor(horizontalMin)} O";
            else if ((x > width / 2) && (y < height / 2))
                return $"{Math.Floor(verticalDegree)}° {Math.Floor(verticalMin)} N, {Math.Floor(horizontalDegree)}° {Math.Floor(horizontalMin)} E";
            else if ((x > width / 2) && (y > height / 2))
                return $"{Math.Floor(verticalDegree)}° {Math.Floor(verticalMin)} N, {Math.Floor(horizontalDegree)}° {Math.Floor(horizontalMin)} O";
            else
                return $"{Math.Floor(verticalDegree)}° {Math.Floor(verticalMin)} S, {Math.Floor(horizontalDegree)}° {Math.Floor(horizontalMin)} E";
        }
    }
}
