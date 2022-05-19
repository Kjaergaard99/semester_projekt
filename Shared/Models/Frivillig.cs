using System;
using Dapper;
using Npgsql;

namespace semester_projekt.Shared.Models
{
    public class Frivillig : Bruger
    {
        // hvilken af disse to løsninger er bedst?
        private List<Kompetence> kompetencer = new List<Kompetence>();

        public int KompetenceId { get; set; }


        public Frivillig()
        {

        }
    }
}

