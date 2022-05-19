using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using semester_projekt.Shared.Models;
using semester_projekt.Server.Models;
using System;
using Dapper;
using Npgsql;
using semester_projekt.Client.Services;
using System.Net;
using Microsoft.Net.Http;

namespace semester_projekt.Server.Models
{
    public class KoordinatorRepository : IKoordinatorRepository
    {
        string connString = "User ID=postgres;Password=qrm49zyp;Host=localhost;Port=5432;Database=2_semester_projekt;";
        string sql = "";

        // FestivalDBContext db = new FestivalDBContext(); // skal denne linje være ligesom mini-projekt?

        /*
        public List<Vagt> GetAlleVagter()
        {
            Console.WriteLine("getAlleVagter koordinatorRepository");
            // kode; Find.ToList eller noget i den dur

        }
        */

        public void AddVagt(Vagt vagt)
        {
            Console.WriteLine("addVagt koordinatoRepository");
            // kode; insertOne(vagt)
        }


        public void UpdateVagt(int id)
        {
            Console.WriteLine("addVagt koordinatoRepository");
            // kode; updateOne(id)
        }

        public void DeleteVagt(int id)
        {
            Console.WriteLine("addVagt koordinatoRepository");
            // kode; deleteOne(id) tror jeg, eller skal det være sql queries?
        }

        /*
        public async Task IEnumerable<Vagt> GetAlleFrivillige()
        {
            sql = @"SELECT b.""bruger_id"" AS BrugerId, b.""bruger_navn"" AS BrugerNavn, b.""bruger_email"" AS BrugerEmail, b.""rolle_id"" AS RolleId,
            FROM ""bruger""
            WHERE rolle_id = 1";
            Console.WriteLine("getAlleFrivillige koordinatoRepository");
            // kode; find.ToList tror jeg eller skal det være sql queries?
            using (var connection = new NpgsqlConnection(connString))
            {
                var vagter = connection.Query<Vagt>(sql);
            }
            return sql;
        }
        */

        public KoordinatorRepository()
        {
        }
    }
}

