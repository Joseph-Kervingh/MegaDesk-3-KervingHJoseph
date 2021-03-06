﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KervingHJoseph
{
    class DeskQuote
    {
        #region Object member variables
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk newDesk = new Desk();
        private int RushDays;
        private int QuoteAmount;
        #endregion

        #region local variables
        private int SurfaceArea = 0;
        #endregion

        private const int PRICE_BASE = 200;
        private const int SIZE_THRESHOLD = 1000;
        private const int PRICE_PER_DRAWER = 50;

        public DeskQuote(int width, int depth, int drawers, string material, int rushDays)
        {
            newDesk.Width = width;
            newDesk.Depth = depth;
           // newDesk.NumberOfDrawers = drawers;

            SurfaceArea = newDesk.Width * newDesk.Depth;
        }

       /* public int CalculateQuoteTotal()
        {
           return PRICE_BASE + DrawerCost() + ;
        }*/

       /* private int DrawerCost();
        { 
          return newDesk.NumberOfDrawers*PRICE_PER_DRAWER;
        }*/
    }
}
