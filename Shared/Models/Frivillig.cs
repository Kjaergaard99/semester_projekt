using System;
using Dapper;
using Npgsql;

namespace semester_projekt.Shared.Models
{
    public class Frivillig : Bruger
    {
        public string Kompetencer { get; set; }


        public Frivillig()
        {
        }
    }
}

