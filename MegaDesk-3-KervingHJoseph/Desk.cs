using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KervingHJoseph
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberofDrawers { get; set; }
        public string DesktopMaterial { get; set; }

        //Desk Contraints / Constants

        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 24;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
    }
}
