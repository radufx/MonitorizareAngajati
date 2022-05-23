using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace MonitorizareAngajati.persistence
{
    [Table(Name ="Tasks")]
    class Tasks
    {
        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int id { get; set; }

        [Column(Name = "userID", DbType = "INTEGER")]
        public int userID { get; set; }

        [Column(Name = "status", DbType = "VARCHAR")]
        public string status { get; set; }

        [Column(Name = "description", DbType = "VARCHAR")]
        public string description { get; set; }
    }
}
