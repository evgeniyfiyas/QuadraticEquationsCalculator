using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Hosting;

public partial class FormInput : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var rq = Context.Request;
        var rs = Context.Response;

        int a = int.Parse(rq.Form["a_value"]);
        int b = int.Parse(rq.Form["b_value"]);
        int c = int.Parse(rq.Form["c_value"]);

        string equationString = string.Format("{0}x<sup>2</sup> {1}x {2}", a, b.ToString("+#;-#;0"), c.ToString("+#;-#;+0"));

        Context.Response.Write(string.Format(new StreamReader(HostingEnvironment.ApplicationPhysicalPath + "App_Code/Html/Templates/template.html").ReadToEnd(),
            equationString,
            new HtmlRenderer(EquationSolver.Solve(a, b, c)).Render()));
    }
}