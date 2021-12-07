using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSQL.Data.Tables
{
    [Table("Users")]
    class Users
    {
        [Key]
        public Guid Id { get; private set; }

        public string FirstName { get; set; }
        public string lastName { get; set; }

        [Unique]
        public string Login { get; set; }

        public string Password { get; set; }
        
        public bool Administrator { get; set; }

        public Users()
        {
            Id = Guid.NewGuid();
        }
    }
}
