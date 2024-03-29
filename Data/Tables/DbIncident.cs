﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormSQL.Data.Tables;

[Table("Incidents")]
public class DbIncident
{
	public DbIncident()
	{
		CreationDate = DateTime.Now;
	}

	[Key] public int Id { get; set; }

	public string Title { get; set; }
	public string Requisites { get; set; }
	public string Author { get; set; }
	public Guid AuthorId { get; set; }
	public DateTime CreationDate { get; set; }
	public string Content { get; set; }
}