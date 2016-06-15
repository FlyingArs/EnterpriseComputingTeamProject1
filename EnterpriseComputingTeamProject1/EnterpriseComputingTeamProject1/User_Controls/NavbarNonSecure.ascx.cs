using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseComputingTeamProject1.User_Controls
{
    public partial class NavbarNonSecure : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetActivePage();
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
                case "Games":
                    games.Attributes.Add("class", "active");
                    break;
                case "Teams":
                    teams.Attributes.Add("class", "active");
                    break;
                case "Log In":
                    login.Attributes.Add("class", "active");
                    break;
            }
        }
    }
}