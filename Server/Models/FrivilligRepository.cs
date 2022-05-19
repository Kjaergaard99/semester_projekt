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
	internal class FrivilligRepository : IFrivilligRepository
	{
        string connString = "User ID=postgres;Password=qrm49zyp;Host=localhost;Port=5432;Database=2_semester_projekt;";
        string sql = "";

        public async Task<IEnumerable<Vagt>> GetMineVagter(int brugerId)
        {
            sql = $@"SELECT * FROM vagt
            WHERE bruger_id = {brugerId}";
            
            Console.WriteLine("getMineVagter frivilligRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var mineVagter = await connection.QueryAsync<Vagt>(sql);
                return mineVagter;
            }
        }


		public async Task<IEnumerable<Vagt>> GetLedigeVagter()
        {
            sql = @"SELECT * FROM vagt
            WHERE bruger_id IS NULL"; // IS NULL eller = null?
          
            Console.WriteLine("getLedigeVagter frivilligRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var alleVagter = await connection.QueryAsync<Vagt>(sql);
                return alleVagter;
            }
        }


		public void BookVagt(int vagtId, int brugerId)
        {
            sql =
                $@"UPDATE vagt
                SET bruger_id = {brugerId}
                WHERE vagt_id = {vagtId} AND 
                WHERE bruger_id IS NULL"; // er denne linje kode nødvendig?

            Console.WriteLine("bookVagt frivilligRepository");
        }



		public FrivilligRepository()
		{
		}
	}
}

