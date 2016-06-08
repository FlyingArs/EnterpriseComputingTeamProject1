using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnterpriseComputingTeamProject1
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            //Send data to the database
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            //Go To Registration Page
            Response.Redirect("Register.aspx");
        }
    }
 }