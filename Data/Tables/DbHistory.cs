﻿using SQLite.CodeFirst;
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
    public class DbHistory
    {
        [Key]
        public Guid Id { get; set; }

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
