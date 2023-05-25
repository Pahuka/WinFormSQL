using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormSQL.Data.Tables
{
    [Table("History")]
    public class DbHistory
    {
        [Key]
        public Guid Id { get; private set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IncidentNumber { get; set; }
        public Guid UserId { get; set; }
        public DateTime EditingDate { get; set; }
        public string Content { get; set; }

        public DbHistory()
        {
            Id = Guid.NewGuid();
            EditingDate = DateTime.Now;
        }
    }
}
