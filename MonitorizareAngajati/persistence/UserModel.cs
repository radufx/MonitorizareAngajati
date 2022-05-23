using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Linq.Mapping;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorizareAngajati.persistence
{
    [Table(Name = "Users")]
    public class Users
    {
        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int id { get; set; }

        [Column(Name = "username", DbType = "VARCHAR")]
        public string username { get; set; }

        [Column(Name = "name", DbType = "VARCHAR")]
        public string name { get; set; }

        [Column(Name = "password", DbType = "VARCHAR")]
        public string password { get; set; }
    }
}
