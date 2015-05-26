using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleDarts
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void commenceGameButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            int Player1 = 0;
            int Player2 = 0;
            Random dartGenerator = new Random();
            while (Player1 < 400 && Player2 < 400)
            {
                for (int i = 0; i < 3; i++)
                {
                    int pointsThisThrow = Score.calculateScore(Dart.Throw(dartGenerator), dartGenerator);
                    Player1 += pointsThisThrow;
                    resultLabel.Text += String.Format("</br>Player 1 has scored {0} with their number {1} Throw", pointsThisThrow, (i + 1));                    
                }
                for (int i = 0; i < 3; i++)
                {
                    int pointsThisThrow = Score.calculateScore(Dart.Throw(dartGenerator), dartGenerator);
                    Player2 += pointsThisThrow;
                    resultLabel.Text += String.Format("</br>Player 2 has scored {0} with their number {1} Throw", pointsThisThrow, (i + 1));
                }
                resultLabel.Text += (string)"</br>";
            }
            string winner;
            if (Player1 > Player2) winner = "1";
            else if (Player2 > Player1) winner = "2";
            else winner = "Players tied play new game to determine a winner";

            finalScoreLabel.Text = String.Format("Player1:{0} </br> Player2:{1} </br> Player{2} Wins!", Player1, Player2, winner);
            if (Player1 == Player2) finalScoreLabel.Text = String.Format("Player1:{0} </br> Player2:{1} </br> Player{2}", Player1, Player2, winner); 
        }        
    }
}