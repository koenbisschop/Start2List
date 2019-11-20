using System;

namespace DoubleBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //eendimensionale array
            int[] cijferRij = new int[5] { 1, 3, 5, 7, 11 };
            //2-dimensionale array
            //2 versies
            //versie 1 = rectangular array
            int[,] werkblad1 = new int[ , ] { { 1, 2 }, { 3, 4 } };
            //versie 2 = array van arrays
            int[][] werkblad = new int[][] { new int[]{ 1, 3, 5 }, new int[]{ 2, 4, 6 } };
        }
    }
}
