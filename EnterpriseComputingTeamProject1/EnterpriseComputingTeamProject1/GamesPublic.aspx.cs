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
                this.GetGames();
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
        protected void GetGames()
        {
            //connect to EF
            using (DefaultConnection db = new DefaultConnection())
            {

                //query the Students Table using EF and LINQ

                var Games = (from allGames in db.Games
                             join allTeams in db.Teams on allGames.Team1ID equals allTeams.TeamID
                             where allGames.Week == 1
                             select new {
                                 allGames.Week,
                                 allGames.GameName,
                                 allGames.GameDescription,
                                 allGames.NumberOfSpectators,
                                 TotalScore = allGames.Team1Score + allGames.Team2Score,
                                 Winner = ((allGames.Team1Score - allGames.Team2Score > 0) ? allGames.Team1ID : allGames.Team2ID)});

                //bind the result to the GridView
                GamesGridView.DataSource = Games.ToList();
                //StudentsGridView.DataSource = Students.ToList();
                GamesGridView.DataBind();
            }
        }
    }
    }
