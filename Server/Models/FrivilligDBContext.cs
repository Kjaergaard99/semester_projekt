using System;
using Dapper;
using Npgsql;

namespace semester_projekt.Server.Models
{
	public class FrivilligDBContext
	{
		private readonly NpgsqlConnection npgsqlConnection;


		public FrivilligDBContext()
		{
			string connString = "User ID=postgres;Password=qrm49zyp;Host=localhost;Port=5432;Database=2_semester_projekt;";

			


		}
	}
}

