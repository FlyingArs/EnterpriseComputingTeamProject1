using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

// using statements that are required to connect to EF DB
using EnterpriseComputingTeamProject1.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;


namespace EnterpriseComputingTeamProject1
{
    public partial class TeamsPublic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ////if loading the page for the first time, populate the student grid
            //if (!IsPostBack)
            //{
            //    Session["SortColumn"] = "TeamID";
            //    Session["SortDirection"] = "ASC";
            //    //get the student data
            //    this.GetTeams();
            //}
        }

        /**
         * <summary>
         * This method gets teams data from DB
         * </summary>
         * 
         * @method GetTeams
         * @return {void}
         */
        //protected void GetTeams()
        //{
        //    string sortString = Session["SortColumn"].ToString() + " " + Session["SortDirection"].ToString();

        //    // connect to EF
        //    using (DefaultConnection db = new DefaultConnection())
        //    {
        //        //query the teams from table using EF and LINQ
        //        var teams = (from allTeams in db.Teams
        //                     select allTeams);
        //        //bind the results to GridView
        //        TeamsGridView.DataSource = teams.AsQueryable().OrderBy(sortString).ToList();
        //        TeamsGridView.DataBind();
        //    }
        //}

        //protected void PageSizeDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // set the new page size
        //    TeamsGridView.PageSize = Convert.ToInt32(PageSizeDropDownList.SelectedValue);

        //    //refresh the grid
        //    this.GetTeams();
        //}

        //protected void TeamsGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    // set the new page number
        //    TeamsGridView.PageIndex = e.NewPageIndex;

        //    // refresh the grid
        //    this.GetTeams();
        //}

        //protected void TeamsGridView_Sorting(object sender, GridViewSortEventArgs e)
        //{
        //    // get the column to sort by
        //    Session["SortColumn"] = e.SortExpression;

        //    //toggle the direction
        //    Session["SortDirection"] = Session["SortDirection"].ToString() == "ASC" ? "DESC" : "ASC";

        //    //refresh the grid
        //    this.GetTeams();
        //}

        //protected void TeamsGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if (IsPostBack)
        //    {
        //        //check to see if the click is on the header row
        //        if (e.Row.RowType == DataControlRowType.Header)
        //        {
        //            LinkButton linkbutton = new LinkButton();

        //            for (int index = 0; index < TeamsGridView.Columns.Count; index++)
        //            {
        //                if (TeamsGridView.Columns[index].SortExpression == Session["SortColumn"].ToString())
        //                {
        //                    if (Session["SortDirection"].ToString() == "ASC")
        //                    {
        //                        linkbutton.Text = "<i class='fa fa-caret-up fa-lg'></i>";
        //                    }
        //                    else
        //                    {
        //                        linkbutton.Text = "<i class='fa fa-caret-down fa-lg'></i>";
        //                    }

        //                    e.Row.Cells[index].Controls.Add(linkbutton);
        //                }
        //            }
        //        }
        //    }
        //}
    }
}