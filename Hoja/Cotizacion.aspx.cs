using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hoja
{
    public partial class Cotizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<string> locations = new List<string>(); // however this initialized 
            locations.Add("Home");
            locations.Add("Cotizador");
            locations.Add("Panel 1");
            locations.Add("Panel 2");

            StringBuilder sb = new StringBuilder();

            sb.Append("<ul id=\"tabs\">");

            for (int i = 0; i < locations.Count; i++)
            {
                sb.Append("<li id=\"tab" + i.ToString() + "\"><a href=\"" + locations[i] + "\">" + locations[i].ToString() + "</a></li>");
            }

            sb.Append("</ul>");

            litMarkup.Text = sb.ToString();
        }
    }
}