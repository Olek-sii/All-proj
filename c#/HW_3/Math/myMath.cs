using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMath
{
    public class myMath
    {
        const double G = 9.81;
        public static double CountDistanceOfThrowByDeg(double degrees, double speed)
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException();
            double speedMetrPerSec = speed * 1000 / 3600;
            double radDeg = degrees * Math.PI / 180;
            double res = Math.Pow(speedMetrPerSec, 2) * Math.Sin(2 * radDeg) / G;
            return res;
        }

        public static double CountDistanceOfThrowByRad(double radians, double speed)
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException();
            double speedMetrPerSec = speed * 1000 / 3600;
            double res = Math.Pow(speedMetrPerSec, 2) * Math.Sin(2 * radians) / G;
            return res;
        }

        public static double CountDistanceBetweenCars(double v1, double v2, double t, double s)
        {
            if (v1 < 0 || v2 < 0 || t < 0 || s < 0) //по смыслу условия скорость не должна быть отрицательной
                throw new ArgumentOutOfRangeException();
            return (v1 + v2) * t + s;
        }

        public static bool IsPointInsideShadedArea(double x, double y)
        {
            if (x >= 0 && x >= y && y >= 3d / 2 * x - 1)
            {
                return true;
            }
            if (x < 0 && x <= -y && y >= -3d / 2 * x - 1)
            {
                return true;
            }
            return false;
        }

        public static double CountValue(double x)
        {
            double z;
            z = 6 * Math.Log(Math.Sqrt(Math.Exp(x + 1) + 2 * Math.Exp(x) * Math.Cos(x)));
            z /= Math.Log(x - Math.Exp(x + 1) * Math.Sin(x));
            z += Math.Abs(Math.Cos(x) / Math.Exp(Math.Sin(x)));
            return z;
        }
    }
}
