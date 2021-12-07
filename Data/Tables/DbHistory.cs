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
    [Table("History")]
    class DbHistory
    {
        [Key]
        public Guid Id { get; set; }
        [Unique]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IncidentId { get; set; }
        public Guid UserId { get; set; }
        public DateTime EditingDate { get; set; }
        public string Content { get; set; }

        public DbHistory(string update, int incidentId)
        {
            Id = Guid.NewGuid();
            EditingDate = DateTime.Now;
            Content = update;
            IncidentId = incidentId;
        }
    }
}
