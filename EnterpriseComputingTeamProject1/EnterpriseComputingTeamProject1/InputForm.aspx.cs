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
            //Use EF to connect to  the server
            using (GTConnection db = new GTConnection())
            {
                //if two team IDs are not equal then insert the data into game table, otherwise pop up a message
                //if (team1ID != team2ID)
                //{
                    //save the information to the database
                    //use the Student model to create a new student object and
                    //save a new record
                    Game game = new Game();

                    game.Week = Convert.ToInt32(WeekDropDownList.SelectedValue);
                    game.GameName = GameNameTextBox.Text;
                    game.GameDescription = GameDescriptionTextBox.Text;
                    game.Team1ID = Convert.ToInt32(Team1DropDownList.SelectedValue);
                    game.Team2ID = Convert.ToInt32(Team2DropDownList.SelectedValue);
                    game.Team1Score = Convert.ToInt32(Team1ScoreTextBox.Text);
                    game.Team2Score = Convert.ToInt32(Team2ScoreTextBox.Text);
                    game.NumberOfSpectators = Convert.ToInt32(NumberOfSpectatorsTextBox.Text);

                    //add the game object to 
                    db.Games.Add(game);
                    
                    //save changes
                    db.SaveChanges();

                    //Redirect back to the updated students page
                    Response.Redirect("~/Games.aspx");
                //}
                //else
                //{
                    //Response.Write("<script>alert('A team cannot play against itself')</script>");
                //}


                //Redirect back to the updated students page
                Response.Redirect("~/Games.aspx");
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