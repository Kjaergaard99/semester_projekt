using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using semester_projekt.Shared.Models;
using semester_projekt.Server.Models;
using System;
using Dapper;
using Npgsql;
using semester_projekt.Client.Services;
using Microsoft.Net.Http;

namespace semester_projekt.Server.Models
{
    internal class KoordinatorRepository : IKoordinatorRepository
    {
        string connString = "User ID=postgres;Password=qrm49zyp;Host=localhost;Port=5432;Database=2_semester_projekt;";
        string sql = "";

        // FestivalDBContext db = new FestivalDBContext(); // skal denne linje være ligesom mini-projekt?

        
        public async Task<IEnumerable<Vagt>> GetAlleVagter()
        {
            sql = @"SELECT * FROM vagt_opgave";
            
            Console.WriteLine("getAlleVagter koordinatorRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var alleVagter = await connection.QueryAsync<Vagt>(sql);
                return alleVagter.ToList();
            }
        }

        public async void AddVagt(Vagt vagt)
        {
            sql =
                $@"CALL opret_vagt ({vagt.VagtId}, {vagt.Dato}, {vagt.VagtStart}, {vagt.VagtSlut}, {vagt.Pause}, {vagt.Område}, {vagt.OpgaveId}, {vagt.BrugerId})";
            
            Console.WriteLine("addVagt koordinatorRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var opretVagt = await connection.ExecuteAsync(sql);
            }
        }


        public async void UpdateVagt(int vagtId, Vagt vagt)
        {
            sql =
                $@"UPDATE vagt
                SET dato = {vagt.Dato}, ""vagt_start"" = {vagt.VagtStart}, ""vagt_slut"" = {vagt.VagtSlut}, pause = {vagt.Pause}, område = {vagt.Område},
                    ""opgave_id"" = {vagt.OpgaveId}, ""er_booket"" = {vagt.ErBooket}, ""bruger_id"" = {vagt.BrugerId}
                WHERE vagt_id = {vagtId}";
            
            Console.WriteLine("addVagt koordinatorRepository");

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
            
            Console.WriteLine("addVagt koordinatorRepository");
        }

        
        public async Task<IEnumerable<Bruger>> GetAlleFrivillige()
        {
            sql = @"SELECT * FROM frivillig_kompetencer";
            
            Console.WriteLine("getAlleFrivillige koordinatorRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var alleFrivillige = await connection.QueryAsync<Bruger>(sql);
                return alleFrivillige.ToList();
            }
        }

        // er ikke sikker på om dette er et krav?
        public async void AddOpgave(Opgave opgave)
        {
            sql =
                $@"INSERT INTO opgave (""opgave_beskrivelse"")
                    VALUES ({opgave.OpgaveBeskrivelse})";
            
            Console.WriteLine("addOpgave koordinatorRepository");

            using (var connection = new NpgsqlConnection(connString))
            {
                var opretOpgave = await connection.ExecuteAsync(sql);
            }
        }
        

        public KoordinatorRepository()
        {
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
        }
    }
}

