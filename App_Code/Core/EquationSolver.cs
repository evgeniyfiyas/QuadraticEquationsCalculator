using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EquationSolver
/// </summary>
public static class EquationSolver
{
    public static List<double> Solve(int a, int b, int c)
    {
        var result = new List<double>();

        var d = (b * b) - (4 * a * c);

        if (d == 0)
        {
            result.Add(-b / 2 * a);
        }
        else if (d > 0)
        {
            result.Add((-b - Math.Sqrt(d)) / 2 * a);
            result.Add((-b + Math.Sqrt(d)) / 2 * a);
        }

        return result;
    }
}