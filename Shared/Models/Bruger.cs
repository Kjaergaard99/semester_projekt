using System;
using Dapper;
using Npgsql;

namespace semester_projekt.Shared.Models
{
    public class BrugerDTO
    {
        public int BrugerId { get; set; }
        public string BrugerNavn { get; set; }
        public int BrugerEmail { get; set; }
        public string BrugerPassword { get; set; }
        public int RolleId { get; set; }


        public BrugerDTO()
        {

        }
    }
}