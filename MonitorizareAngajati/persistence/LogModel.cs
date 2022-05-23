using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.persistence
{
    [Table(Name = "Logs")]
    public class Logs
    {
        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int id { get; set; }

        [Column(Name = "time", DbType = "VARCHAR")]
        public string time { get; set; }

        [Column(Name = "userID", DbType = "INTEGER")]
        public int userID { get; set; }
    }
}
