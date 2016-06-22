/** Authors & Student Number:
    Fei Wang 200278460
    Siqian Yu 200286902
    Date Modified: 06-19-2016
    File Description: This is the backend file for InputForm that handles all the inputting info into the database.
    **/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using statements required for EF DB access
using EnterpriseComputingTeamProject1.Models;
using System.Web.ModelBinding;


namespace EnterpriseComputingTeamProject1
{
    public partial class InputForm : System.Web.UI.Page
    {
        int team1ID;
        int team2ID;

        protected void Page_Load(object sender, EventArgs e)
        {
            // if this is to update the game data, show the existing game info
            if ((!IsPostBack) && (Request.QueryString.Count > 0))
            {
                this.GetGame();
            }
        }

        /**
         * <summary>
         * This method gets the game data from DB and displays in the GridView
         * </summary>
         * 
         * @method GetGame
         * @return {void}
         */
        protected void GetGame()
        {
            // populate the form with existing data from the database
            int GameID = Convert.ToInt32(Request.QueryString["GameID"]);

            // connect to the EF DB
            using (GTConnection db = new GTConnection())
            {
                // populate a game object instance with the GameID from the URL Parameter
                Game updatedGame = (from game in db.Games
                                    where game.GameID == GameID
                                    select game).FirstOrDefault();

                // map the game properties to the form controls
                if (updatedGame != null)
                {
                    WeekDropDownList.SelectedValue = updatedGame.Week.ToString();
                    GameNameTextBox.Text = updatedGame.GameName;
                    GameDescriptionTextBox.Text = updatedGame.GameDescription;
                    Team1DropDownList.SelectedValue = updatedGame.Team1ID.ToString();
                    Team1ScoreTextBox.Text = updatedGame.Team1Score.ToString();
                    Team2DropDownList.SelectedValue = updatedGame.Team2ID.ToString();
                    Team2ScoreTextBox.Text = updatedGame.Team2Score.ToString();
                    NumberOfSpectatorsTextBox.Text = updatedGame.NumberOfSpectators.ToString();
                }
            }
        }

        protected void WeekDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int week = Convert.ToInt32(WeekDropDownList.SelectedValue);
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            //Redirect to Students Page
            Response.Redirect("~/Games.aspx");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            //if two team IDs are not equal then insert the data into game table, otherwise pop up a message
            if (team1ID != team2ID)
            {
                //Use EF to connect to  the server
                using (GTConnection db = new GTConnection())
                {
                    //save the information to the database
                    //use the Game model to create a new game object and
                    //save a new record
                    Game newGame = new Game();

                    int GameID = 0;
                    if (Request.QueryString.Count > 0) // our URL has a GameID in it
                    {
                        // get the id from the URL
                        GameID = Convert.ToInt32(Request.QueryString["GameID"]);

                        // get the current student from EF DB
                        newGame = (from game in db.Games
                                   where game.GameID == GameID
                                   select game).FirstOrDefault();
                    }



                    newGame.Week = Convert.ToInt32(WeekDropDownList.SelectedValue);
                    newGame.GameName = GameNameTextBox.Text;
                    newGame.GameDescription = GameDescriptionTextBox.Text;
                    newGame.Team1ID = Convert.ToInt32(Team1DropDownList.SelectedValue);
                    newGame.Team2ID = Convert.ToInt32(Team2DropDownList.SelectedValue);
                    newGame.Team1Score = Convert.ToInt32(Team1ScoreTextBox.Text);
                    newGame.Team2Score = Convert.ToInt32(Team2ScoreTextBox.Text);
                    newGame.NumberOfSpectators = Convert.ToInt32(NumberOfSpectatorsTextBox.Text);

                    //add the game object to 
                    if (GameID == 0)
                    {
                        db.Games.Add(newGame);
                    }

                    //save changes
                    db.SaveChanges();

                    //Redirect back to the updated students page
                    Response.Redirect("~/Games.aspx");
                }

            
                //}
                //else
                //{
                    //Response.Write("<script>alert('A team cannot play against itself')</script>");
                //}


                //Redirect back to the updated students page
                //Response.Redirect("~/Games.aspx");
            }
            else
            {
                
            }
        }

        protected void Team1DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Save the Team Info into a varaible

            team1ID = Convert.ToInt32(Team1DropDownList.SelectedValue);
        }

        protected void Team2DropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            team2ID = Convert.ToInt32(Team2DropDownList.SelectedValue);
        }

    }
}