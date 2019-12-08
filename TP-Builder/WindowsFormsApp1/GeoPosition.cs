using System;

namespace TPBuilder
{
    static class GeoPosition
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
    }
}
