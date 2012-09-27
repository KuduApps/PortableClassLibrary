using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PortableCalculator;

namespace PortableClassLibrary
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calculator cal = new Calculator();
            Random rdm = new Random(100);
            int a = rdm.Next(100);
            int b = rdm.Next(100);

            int result = cal.Add(a, b);
            Response.Write("The result is : " + result.ToString());
        }
    }
}