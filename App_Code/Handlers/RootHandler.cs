using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;

/// <summary>
/// Summary description for RootHandler
/// </summary>
public class RootHandler : IHttpHandler
{
    public RootHandler() { }

    public bool IsReusable => false;

    public void ProcessRequest(HttpContext context)
    {
        var rq = context.Request;
        var rs = context.Response;

        var parsed = rq.Path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

        if (!int.TryParse(parsed[1], out int a) || !int.TryParse(parsed[2], out int b) || !int.TryParse(parsed[3], out int c)) // parsed[0] == "solve"
        {
            rs.StatusCode = 400;
            rs.Write("400 Bad Request");
            return;
        }

        string equationString = string.Format("{0}x<sup>2</sup> {1}x {2}", a, b.ToString("+#;-#;0"), c.ToString("+#;-#;+0"));

        rs.Write(string.Format(new StreamReader(HostingEnvironment.ApplicationPhysicalPath + "App_Code/Html/Templates/template.html").ReadToEnd(), 
            equationString, 
            new HtmlRenderer(EquationSolver.Solve(a, b, c)).Render()));
    }
}