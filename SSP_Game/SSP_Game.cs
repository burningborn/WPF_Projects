using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSP_Game
{
    public class SSP_Game
    {
        public string[] Game = new string[] { "Stone", "Scissors", "Paper" };      
        public string status = null;


        public void Bones()
        {
            Random rnd = new Random();
            this.status = Game[rnd.Next(0, 3)];
        }

        static public int Fight(SSP_Game one, SSP_Game two)
        {
            int key = 3;
            if (one.status == "Stone" && two.status == "Stone")
                key = 0;
            if (one.status == "Stone" && two.status == "Scissors")
                key = 1;
            if (one.status == "Stone" && two.status == "Paper")
                key = -1;

            if (one.status == "Scissors" && two.status == "Scissors")
                key = 0;
            if (one.status == "Scissors" && two.status == "Paper")
                key = 1;
            if (one.status == "Scissors" && two.status == "Stone")
                key = -1;

            if (one.status == "Paper" && two.status == "Paper")
                key = 0;
            if (one.status == "Paper" && two.status == "Stone")
                key = 1;
            if (one.status == "Paper" && two.status == "Scissors")
                key = -1;

            return key;
        }
    }
}
