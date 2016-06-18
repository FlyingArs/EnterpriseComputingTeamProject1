using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Database;
using EnterpriseComputingTeamProject1.Models;
using System.Web.ModelBinding;


namespace EnterpriseComputingTeamProject1
{
    public partial class GamesPublic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading the page for the first time, populate the games grid
            if (!IsPostBack)
            {

                //get the game data
                this.GetGames(week);
            }
        }

        /**
 * <summary>
 * This method gets the student data from the DB
 * </summary>
 *
 * @method GetStudents
 * @returns {void}
 */
        int week = 1;

        protected void GetGames(int week)
        {
            

            //connect to EF
            using (GTConnection db = new GTConnection())
            {

                //query the Students Table using EF and LINQ

                var Games = (from allGames in db.Games
                             join allTeams in db.Teams on allGames.WinningID equals allTeams.TeamID
                             where allGames.Week == week
                             select new
                             {
                                 allGames.Week,
                                 allGames.GameName,
                                 allGames.GameDescription,
                                 allGames.NumberOfSpectators,
                                 TotalScore = allGames.Team1Score + allGames.Team2Score,
                                 //Winner = ((allGames.Team1Score - allGames.Team2Score > 0) ? allGames.Team1ID : allGames.Team2ID)}
                                 Winner = allTeams.TeamName
                             });

               // var teamOne = (from Teams in db.Teams where Team.ID = Games.Team1ID select Team);
               // var teamTwo = (from Teams in db.Teams where Team.ID = Games.Team2ID select Team);





                //bind the result to the GridView
                GamesGridView.DataSource = Games.ToList();
                //StudentsGridView.DataSource = Students.ToList();
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
    }
    }
