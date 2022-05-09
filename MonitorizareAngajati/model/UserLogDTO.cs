using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.model
{
    public class UserLogDTO
    {
        private string name;
        private string time;

        public UserLogDTO(string name, string time)
        {
            this.name = name;
            this.time = time;
        }

        public string Name { get => name; set => name = value; }
        public string Time { get => time; set => time = value; }
    }
}
