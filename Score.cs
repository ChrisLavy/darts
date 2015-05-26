using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDarts
{
    public static class Score
    {
        public static int calculateScore(int dartValue , Random critChanceRandom)
        {
            int pointsThisThrow;
            int critChance = critChanceRandom.Next(1, 101);
            if (dartValue == 0)
            {
                if (critChance > 75) pointsThisThrow = 50;
                else pointsThisThrow = 25;
            }
            else if (critChance > 95) pointsThisThrow = (dartValue * 3);
            else if (critChance > 90) pointsThisThrow = (dartValue * 2);
            else pointsThisThrow = dartValue;

            return pointsThisThrow;
        }
    }
}