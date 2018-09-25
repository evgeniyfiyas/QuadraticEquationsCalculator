using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for HtmlRenderer
/// </summary>
public class HtmlRenderer : IRenderable
{
    private List<double> solveResults;

    public HtmlRenderer(List<double> solveResults)
    {
        this.solveResults = solveResults;
    }

    public string Render()
    {
        string rendered;

        if (solveResults.Count == 0)
        {
            rendered = "No answers found. (D < 0)";
        }
        else if (solveResults.Count == 1)
        {
            rendered = "Found 1 solution:<br/>x = " + solveResults[0];
        }
        else
        {
            rendered = string.Format("Found 2 solutions:<br/>x<sub>1</sub> = {0}<br/>x<sub>2</sub> = {1}", solveResults[0], solveResults[1]);
        }

        return rendered;
    }
}