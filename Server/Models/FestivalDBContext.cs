using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using semester_projekt.Shared.Models;
using semester_projekt.Server.Models;
using System;
using Dapper;
using Npgsql;
using semester_projekt.Client.Services;
using System.Net.Http;
using Microsoft.Net.Http;

namespace semester_projekt.Server.Models
{
	public class FestivalDBContext
	{
		private readonly NpgsqlConnection npgsqlConnection; // er dette rigtigt?

		/*
		public FestivalDBContext()
		{
			var db =
				"User ID=postgres;Password=qrm49zyp;Host=localhost;Port=5432;Database=2_semester_projekt;";
			
		}
		*/

	}
}

