using System;
using Dapper;
using Npgsql;
using semester_projekt.Shared.Models;

namespace semester_projekt.Server.Models
{
	public class FestivalDBContext
	{
		private readonly NpgsqlConnection npgsqlConnection; // er dette rigtigt?


		public FestivalDBContext()
		{
			var db =
				"User ID=postgres;Password=qrm49zyp;Host=localhost;Port=5432;Database=2_semester_projekt;";
			
		}


	}
}

