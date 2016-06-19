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

/**
 * @author: David Yu
 * @date: June 17, 2016
 * @version: 0.0.3 - modified page links for OWIN
 */

namespace EnterpriseComputingTeamProject1
{
    public partial class Navbar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // check if a user is logged in
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {                   
                    // show the secured content area
                    SecurePlaceHolder.Visible = true;
                    PublicPlaceHolder.Visible = false;
                }
                else
                {
                    // show the public content area
                    SecurePlaceHolder.Visible = false;
                    PublicPlaceHolder.Visible = true;
                }
                SetActivePage();
            }
           
        }

        /**
         * This method adds a css class of "active" to list items related
         * to navigation links of each page
         *
         * @method SetActivePage
         * @return {void}
         */
        private void SetActivePage()
        {
            switch (Page.Title)
            {
                case "Home Page":
                    home.Attributes.Add("class", "active");
                    break;
                case "Login":
                    login.Attributes.Add("class", "active");
                    break;
                case "Register":
                    register.Attributes.Add("class", "active");
                    break;
                case "Games":
                    games.Attributes.Add("class", "active");
                    break;
                case "Teams":
                    teams.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}