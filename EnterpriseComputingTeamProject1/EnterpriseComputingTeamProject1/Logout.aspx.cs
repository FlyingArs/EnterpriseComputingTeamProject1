using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// required for identity for owin
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace EnterpriseComputingTeamProject1
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // store session infomation
            var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;

            // sign out
            authenticationManager.SignOut();

            //redirect to Home Page
            Response.Redirect("~/Default.aspx");
        }
    }
}