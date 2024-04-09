using System;
using System.Collections.Generic;

namespace Lab63;

public class Variant14
{
    public static double GetSrSum(double[,] matrix)
    {
        double sum = 0;
        var count = 0;

        for (var j = 8; j >= 4; j--)
        {
            for (var i = 8 - j; i <= j; i++)
            {
                if (matrix[i, j] > 0)
                {
                    sum += matrix[i, j];
                    count++;
                }
            }
        }

        return Math.Round(sum / count, 2);
    }

    public static double[] GetNegativeElements(double[,] matrix)
    {
        var array = new List<double>();

        for (var j = 8; j >= 4; j--)
        {
            for (var i = 8 - j; i <= j; i++)
            {
                if (matrix[i, j] < 0)
                {
                    array.Add(matrix[i, j]);
                }
            }
        }

        return array.ToArray();
    }

    public static double[] GetProducts(double[,] matrix)
    {
        var array = new List<double>();

        for (var j = 8; j >= 4; j--)
        {
            double product = 1;

            for (var i = 8 - j; i <= j; i++)
            {
                product *= matrix[i, j];
            }

            array.Add(product);
        }

        return array.ToArray();
    }

    public static double[,] Replace(double[,] matrix)
    {
        for (var j = 5; j < 9; j++)
        {
            for (var i = 0; i < 9; i++)
            {
                if (matrix[i, j] == 12)
                {
                    matrix[i, j] = -1;
                }
            }
        }

        return matrix;
    }
}