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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    // show the secured menu area
                    SecureMenuPlaceHolder.Visible = true;
                    PublicMenuPlaceHolder.Visible = false;
                }
                else
                {
                    // show the public menu area
                    SecureMenuPlaceHolder.Visible = false;
                    PublicMenuPlaceHolder.Visible = true;
                }
            }
        }
    }
}