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

        
        public async Task<IEnumerable<Vagt>> GetAlleVagter()
        {
            sql = @"SELECT * FROM vagt";
            Console.WriteLine("getAlleVagter koordinatorRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var alleVagter = await connection.QueryAsync<Vagt>(sql);
                return alleVagter;
            }
        }

        public async void AddVagt(Vagt vagt)
        {
            sql =
                $@"INSERT INTO vagt (dato, ""vagt_start"", ""vagt_slut"", pause, område, ""opgave_id"", ""er_booket"", ""bruger_id"")
                   VALUES({vagt.Dato}, {vagt.VagtStart}, {vagt.VagtSlut}, {vagt.Pause}, {vagt.Område}, {vagt.OpgaveId}, {vagt.ErBooket}, {vagt.BrugerId})";
            Console.WriteLine("addVagt koordinatoRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var opretVagt = await connection.ExecuteAsync(sql);
            }
        }


        public async void UpdateVagt(Vagt vagt, int vagtId)
        {
            sql =
                $@"UPDATE vagt
                SET dato = {vagt.Dato}, ""vagt_start"" = {vagt.VagtStart}, ""vagt_slut"" = {vagt.VagtSlut}, pause = {vagt.Pause}, område = {vagt.Område},
                    ""opgave_id"" = {vagt.OpgaveId}, ""er_booket"" = {vagt.ErBooket}, ""bruger_id"" = {vagt.BrugerId}
                WHERE vagt_id = {vagtId}";
            Console.WriteLine("addVagt koordinatoRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var updateVagt = await connection.ExecuteAsync(sql);
            }
        }

        public void DeleteVagt(int vagtId)
        {
            sql =
                $@"DELETE FROM vagt
                WHERE vagt_id = {vagtId}";
            Console.WriteLine("addVagt koordinatoRepository");
        }

        
        public async Task<IEnumerable<Vagt>> GetAlleFrivillige()
        {
            sql = @"SELECT b.""bruger_id"" AS BrugerId, b.""bruger_navn"" AS BrugerNavn, b.""bruger_email"" AS BrugerEmail, b.""rolle_id"" AS RolleId,
            FROM ""bruger""
            WHERE rolle_id = 1";
            Console.WriteLine("getAlleFrivillige koordinatoRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var alleFrivillige = await connection.QueryAsync<Vagt>(sql);
                return alleFrivillige;
            }
        }

        // er ikke sikker på om dette er et krav?
        public async void addOpgave(Opgave opgave)
        {
            sql =
                $@"INSERT INTO opgave (""opgave_beskrivelse"")
                    VALUES ({opgave.OpgaveBeskrivelse})";
            Console.WriteLine("addOpgave koordinatoRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var opretOpgave = await connection.ExecuteAsync(sql);
            }
        }
        

        public KoordinatorRepository()
        {
        }
    }
}

