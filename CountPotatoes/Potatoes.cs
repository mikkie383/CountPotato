using System;
using System.Collections.Generic;
using System.Text;

namespace CountPotatoes
{
    public class Potatoes
    {

        private int russetBags { get; set; }
        private int redBags { get; set; }

        public int PotatoDifference(int bags)
        {

            if (bags % 2 == 1)
            {
                russetBags = bags;
                redBags = bags - 1;
            }
            else
            {
                russetBags = bags - 1;
                redBags = bags;
            }

            int totalRusset = 0;
            int totalRed = 0;
            for (int i = 1; i <= russetBags; i += 2)
            {
                totalRusset += i * i;
            }

            for (int i = 0; i <= redBags; i += 2)
            {
                totalRed += i * i;
            }

            return Math.Abs(totalRusset - totalRed);
        }
    }
}
