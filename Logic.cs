using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{

    public static class Logic
    {

        public static string SumVect(Form1.coord vect1, Form1.coord vect2)
        {
            string message;

            Form1.coord result = new Form1.coord();
            result.x = vect1.x + vect2.x;
            result.y = vect1.y + vect2.y;
            result.z = vect1.z + vect2.z;
            message = "{ " + Math.Round(result.x, 2) + " ; " + Math.Round(result.y, 2) + " ; " + Math.Round(result.z, 2) + " }";
            return message;
        }

        public static string MinusVect(Form1.coord vect1, Form1.coord vect2)
        {
            string message;

            Form1.coord result = new Form1.coord();
            result.x = vect1.x - vect2.x;
            result.y = vect1.y - vect2.y;
            result.z = vect1.z - vect2.z;
            message = "{ " + Math.Round(result.x, 2) + " ; " + Math.Round(result.y, 2) + " ; " + Math.Round(result.z, 2) + " } ";
            return message;
        }

        public static float ScalProd(Form1.coord vect1, Form1.coord vect2)
        {
            float result = vect1.x * vect2.x + vect1.y * vect2.y + vect1.z * vect2.z;
            return result; 
        }

        public static double LengtVect(Form1.coord vect)
        {
            double result;

            result = Math.Sqrt(vect.x * vect.x + vect.y * vect.y + vect.z * vect.z);

            return result;
        }

        public static string VectProd(Form1.coord vect1, Form1.coord vect2)
        {
            string message;

            Form1.coord result = new Form1.coord();
            result.x = vect1.y * vect2.z - vect1.z * vect2.y;
            result.y = vect1.x * vect2.z - vect1.z * vect2.x;
            result.z = vect1.x * vect2.y - vect1.y * vect2.x;

            message = "{ " + Math.Round(result.x , 2) + " ; " + Math.Round(result.y, 2) * -1 + " ; " + Math.Round(result.z, 2) + " }";
            return message;
        }

    }
}
