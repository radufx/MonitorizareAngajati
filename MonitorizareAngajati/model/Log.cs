using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.model
{
   public class Log: Entity
    {
        private int userID;
        private string time;

        public Log(int userID, string time)
        {
            this.userID = userID;
            this.time = time;
        }

        public int UserID { get => userID; set => userID = value; }
        public string Time { get => time; set => time = value; }
    }
}
