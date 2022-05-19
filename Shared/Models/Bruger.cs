using System;
using Dapper;
using Npgsql;

namespace semester_projekt.Shared.Models
{
    public class Bruger
    {
        public int BrugerId { get; set; }
        public string BrugerNavn { get; set; }
        public int BrugerEmail { get; set; }
        public string BrugerPassword { get; set; }
        public int TelefonNummer { get; set; }
        public int RolleId { get; set; }

        // public DateOnly FødselsDato { get; set; } // alder skal være 16+


        public Bruger()
        {

        }
    }
}