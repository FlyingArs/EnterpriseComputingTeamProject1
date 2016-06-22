/** Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
    Date Modified: 06-19-2016
    File Description: This is the backend file to display game statistics. 
    **/

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
    public partial class GamesPublic : System.Web.UI.Page
    {
        int week = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading the page for the first time, populate the games grid
            if (!IsPostBack)
            {
                Session["SortColumn"] = "GameID";
                Session["SortDirection"] = "ASC";
                //get the game data
                this.GetGames(week);
            }
        }

        /**
         * <summary>
         * This method gets the game data from the DB
         * </summary>
         *
         * @method GetGames
         * @param {int} week
         * @returns {void}
         */
        protected void GetGames(int week)
        {
            string sortString = Session["SortColumn"].ToString() + " " + Session["SortDirection"].ToString();

            //connect to EF
            using (GTConnection db = new GTConnection())
            {
                //query the Games Table using EF and LINQ
                var Games = (from allGames in db.Games
                             join allTeams in db.Teams on allGames.WinningID equals allTeams.TeamID
                             where allGames.Week == week
                             select new
                             {
                                 allGames.GameID,
                                 allGames.Week,
                                 allGames.GameName,
                                 allGames.GameDescription,
                                 allGames.NumberOfSpectators,
                                 TotalScore = allGames.Team1Score + allGames.Team2Score,
                                 Winner = allTeams.TeamName
                             });

                //bind the result to the GridView
                GamesGridView.DataSource = Games.AsQueryable().OrderBy(sortString).ToList();
                GamesGridView.DataBind();
            }
        }

        protected void WeekDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Store dropdown list into a variable
             int week = Convert.ToInt32(WeekDropDownList.SelectedValue);

            //refresh the grid
            this.GetGames(week);
        }

        protected void GamesGridView_Sorting(object sender, GridViewSortEventArgs e)
        {
            // get the column to sort by
            Session["SortColumn"] = e.SortExpression;

            //toggle the direction
            Session["SortDirection"] = Session["SortDirection"].ToString() == "ASC" ? "DESC" : "ASC";

            //refresh the grid
            this.GetGames(week);
        }

        protected void GamesGridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (IsPostBack)
            {
                //check to see if the click is on the header row
                if (e.Row.RowType == DataControlRowType.Header)
                {
                    LinkButton linkbutton = new LinkButton();

                    for (int index = 0; index < GamesGridView.Columns.Count; index++)
                    {
                        if (GamesGridView.Columns[index].SortExpression == Session["SortColumn"].ToString())
                        {
                            if (Session["SortDirection"].ToString() == "ASC")
                            {
                                linkbutton.Text = "<i class='fa fa-caret-up fa-lg'></i>";
                            }
                            else
                            {
                                linkbutton.Text = "<i class='fa fa-caret-down fa-lg'></i>";
                            }

                            e.Row.Cells[index].Controls.Add(linkbutton);
                        }
                    }
                }
            }
        }

        /**
         * <summary>
         * This event handler deletes a game from the db using EF
         * </summary>
         * 
         * @method GamesGridView_RowDeleting
         * @param {object} sender
         * @param {GridViewDeleteEventArgs} e
         * @returns {void}
         */
        protected void GamesGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // store which row was clicked
            int selectedRow = e.RowIndex;

            // get the selected GameID using the Grid's DataKey collection
            int GameID = Convert.ToInt32(GamesGridView.DataKeys[selectedRow].Values["GameID"]);

            // use EF to find the selected game in the DB and remove it
            using (GTConnection db = new GTConnection())
            {
                // create object of the Student class and store the query string inside of it
                Game deletedGame = (from gameRecords in db.Games
                                       where gameRecords.GameID == GameID
                                       select gameRecords).FirstOrDefault();

                // remove the selected game from the db
                db.Games.Remove(deletedGame);

                // save my changes back to the database
                db.SaveChanges();

                // refresh the grid
                this.GetGames(week);
            }
        }
    }
}
