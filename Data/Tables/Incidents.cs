using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormSQL.Data.Tables
{
    [Table("Incidents")]
    class Incidents
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Requisites { get; set; }
        public Guid Author { get; set; }
        public DateTime CreationDate { get; set; }
        public string Content { get; set; }

        public Incidents()
        {
            CreationDate = DateTime.Now;
        }
    }
}
