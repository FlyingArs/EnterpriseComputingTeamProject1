/** Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
    Date Modified: 06-19-2016
    File Description: This is the backend file to handle user logout.
    **/


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