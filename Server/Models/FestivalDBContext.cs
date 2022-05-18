using System;
using Dapper;
using Npgsql;

namespace semester_projekt.Server.Models
{
	public class FestivalDBContext
	{
		private readonly NpgsqlConnection npgsqlConnection;



		public FestivalDBContext()
		{
			var db =
				"User ID=postgres;Password=qrm49zyp;Host=localhost;Port=5432;Database=2_semester_projekt;";
		}



	}
}

