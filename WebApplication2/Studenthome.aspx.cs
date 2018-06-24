using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication2
{
    public partial class Studenthome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        /*    if(!Page.IsPostBack)
            {
                if(Session["user"]==null)
                {
                   // Response.Write("<script>alert('Your session has been expired.....');window.location.href = 'Login.aspx'</script>");
                }
              else
                {
                    Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
                    Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    Response.Cache.SetNoStore();

                    Response.ClearHeaders();
                    Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
                    Response.AddHeader("Pragma", "no-cache");
                }
            }
            Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.Cache.SetNoStore();

            Response.ClearHeaders();
            Response.AddHeader("Cache-Control", "no-cache, no-store, max-age=0, must-revalidate");
            Response.AddHeader("Pragma", "no-cache");
            */

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Random _rand = new Random();
            int i = _rand.Next(1, 4);
            Image2.ImageUrl = "~/images/" + i.ToString() + ".png";
        }
    }
}
