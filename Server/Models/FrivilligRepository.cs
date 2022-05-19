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
		FestivalDBContext db = new FestivalDBContext(); // skal denne linje være ligesom mini-projekt?

		/*
		public List<Vagt> GetMineVagter()
        {
            Console.WriteLine("getMineVagter frivilligRepository");
			// kode; Find.ToList eller noget i den dur. Eller skal de være sql queries?

		}
		*/

		/*
		public List<Vagt> GetLedigeVagter()
        {
            Console.WriteLine("getLedigeVagter frivilligRepository");
			// kode; Find.ToList eller noget i den dur
        }
		*/

		public void BookVagt(Vagt vagt)
        {
            Console.WriteLine("bookVagt frivilligRepository");
        }



		public FrivilligRepository()
		{
		}
	}
}

