using System;
using Dapper;
using Npgsql;

namespace semester_projekt.Shared.Models
{
    public class Frivillig : Bruger
    {
        private List<Kompetence> kompetencer = new List<Kompetence>();


        public Frivillig()
        {

        }
    }
}

