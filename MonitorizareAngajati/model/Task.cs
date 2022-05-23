using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.model
{
    public class Task: Entity
    {
        private int userID;
        private string status;
        private string description;

        public Task(int userID, string status, string description)
        {
            this.userID = userID;
            this.status = status;
            this.description = description;
        }

        public int UserID { get => userID; set => userID = value; }
        public string Status { get => status; set => status = value; }
        public string Description { get => description; set => description = value; }
    }
}
