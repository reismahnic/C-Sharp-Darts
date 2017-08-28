using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace DartsGame
{
    public class Score
    {
        public static void scoreDart(Player player, Dart dart)
        {
            int score = 0;

            if(dart.isTriple)
            {
                score = dart.Score * 3;
            }
            if(dart.isDouble)
            {
                score = dart.Score * 2;
            }

            if(dart.isTriple && dart.Score == 0)
            {
                score = 50;
            }
            else if (dart.Score == 0)
            {
                score = 25;
            }

            player.Score += score;
        }
    }
}