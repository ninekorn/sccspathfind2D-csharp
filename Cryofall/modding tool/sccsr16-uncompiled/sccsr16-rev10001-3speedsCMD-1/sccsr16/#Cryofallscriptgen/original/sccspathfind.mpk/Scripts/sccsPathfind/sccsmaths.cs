
using System;

using sccsvec2int = sccspathfindstructs.sccsvec2int;
using sccsvec2float = sccspathfindstructs.sccsvec2float;

public static class sccsmaths
{

    public static float DegreeToRadian(float angle)
    {
        return (float)(Math.PI * angle / 180.0f);
    }

    public static float RadianToDegree(float angle)
    {
        return (float)(angle * (180.0f / Math.PI));
    }

    public static float Dot(float aX, float aY, float bX, float bY)
    {
        return (aX * bX) + (aY * bY);
    }

    public static float normalizeradiansfromradians(float radians)
    {
        float degrees = RadianToDegree(radians);
        degrees = degrees % 180;
        if (degrees < 0)
        {
            degrees += 180;
        }
        return DegreeToRadian(degrees);  //DegreeToRadian(degrees);
    }

    public static float normalizedegreesfromdegrees(float degrees)
    {
        //float degrees = RadianToDegree(radians);
        degrees = degrees % 180;
        if (degrees < 0)
        {
            degrees += 180;
        }
        return degrees;  //DegreeToRadian(degrees);
    }




    static System.Random randomer = new System.Random();
    public static float getSomeRandNumThousandDecimal(int minNum, int maxNum, float _decimal, int autonegative, int dontfloor)
    {
        //randomer = new System.Random();
        float num = 0;

        if (dontfloor == -1)
        {
            num = (float)((randomer.NextDouble() * maxNum) + minNum); // this will get a number between 1 and 999;

            if (autonegative == 1)
            {
                num *= (randomer.NextDouble() * 2) == 1 ? 1 : -1; // this will add minus sign in 50% of cases
            }
        }
        else
        {
            num = (float)(Math.Floor(randomer.NextDouble() * maxNum) + minNum); // this will get a number between 1 and 999;

            if (autonegative == 1)
            {
                num *= Math.Floor(randomer.NextDouble() * 2) == 1 ? 1 : -1; // this will add minus sign in 50% of cases
            }
        }

        if (dontfloor == -1)
        {
            return (float)(num);
        }
        else
        {
            return (float)(num * _decimal);

        }
    }

    public static int checknodedistanceint(sccsvec2int nodea, sccsvec2int nodeb)
    {
        var dstX = (float)Math.Abs((nodea.x) - (nodeb.x));
        var dstZ = (float)Math.Abs((nodea.y) - (nodeb.y));

        if (dstX > dstZ)
        {

            return (int)Math.Round(14 * dstZ + 10 * (dstX - dstZ));
        }
        return (int)Math.Round(14 * dstX + 10 * (dstZ - dstX));
    }

    public static float GetDistance(sccsvec2int a, sccsvec2int b)
    {
        return ((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y)); // Mathf.Sqrt
    }
    //https: //stackoverflow.com/questions/13695317/rotate-a-point-around-another-point
    public static sccsvec2int RotatePoint(sccsvec2int pointToRotate, sccsvec2int centerPoint, float angleInDegrees)
    {
        var angleInRadians = angleInDegrees * (Math.PI / 180);
        var cosTheta = Math.Cos(angleInRadians);
        var sinTheta = Math.Sin(angleInRadians);

        var newX = (cosTheta * (pointToRotate.x - centerPoint.x) - sinTheta * (pointToRotate.y - centerPoint.y) + centerPoint.x);
        var newY = (sinTheta * (pointToRotate.x - centerPoint.x) + cosTheta * (pointToRotate.y - centerPoint.y) + centerPoint.y);

        sccsvec2int newPos = new sccsvec2int();
        newPos.x = (int)newX;
        newPos.y = (int)newY;
        return newPos;
    }

    public static float GetDistancefloat2d(sccsvec2float a, sccsvec2float b)
    {
        return (float)((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y)); //Math.Sqrt(
    }
    public static float GetDistancefloat2dsqrt(sccsvec2float a, sccsvec2float b)
    {
        return (float)Math.Sqrt(((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y))); //Math.Sqrt(
    }
}

