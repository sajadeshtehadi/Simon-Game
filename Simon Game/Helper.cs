using System;
using System.Collections.Generic;
using System.Text;

namespace Simon_Game
{
    public class Helper
    {
        public static void ShowHeader(bool showtitel, bool showround, int roundnumber)
        {
            if (showtitel)
            {
                Console.WriteLine("watch the moves");
                Console.WriteLine("b = blue, y = yellow, g = green, r = red");
                Console.WriteLine();
            }
            if (showround)
            {
                Console.WriteLine("Round: " + roundnumber);
            }
        }
    }

}
