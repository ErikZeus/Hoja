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
            locations.Add("Kellen");
            locations.Add("Erik");
      
 
            StringBuilder sb = new StringBuilder();

            sb.Append("<ul id='coolMenu'  >");

            for (int i = 0; i < locations.Count; i++)
            {

                if (locations[i].ToString() == "Erik")
                {
                    sb.Append("<li id=\"tab" + i.ToString() + "\" ><a href=\"" + locations[i] + "\">" + locations[i].ToString() + "</a><ul class='noJS'><li><a href='http://www.grupo-hesse.com'>Gordita</a></li></li>");
                    break;
                }
                if (locations[i].ToString() == "Kellen")
                {
                    sb.Append("<li id=\"tab" + i.ToString() + "\" ><a href=\"" + locations[i] + "\">" + locations[i].ToString() + "</a><ul class='noJS'><li><a href='http://www.grupo-hesse.com'>Gordita</a></li></li>");
                    break;
                }

                sb.Append("<li id=\"tab" + i.ToString() + "\" ><a href=\"" + locations[i] + "\">" + locations[i].ToString() + "</a><ul class='noJS'><li><a href='#'>Hellenico</a></li><li><a href='#'>Genere</a></li><li><a href='#'>Indulgentia</a></li></ul></li>");
        
            }
           
            sb.Append("</ul>");

            coolMenu.Text = sb.ToString();
        }
    }
}