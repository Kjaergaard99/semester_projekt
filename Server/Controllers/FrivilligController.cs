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


namespace semester_projekt.Server.Controllers
{
	[ApiController]
	[Route("api/frivillig")]

	public class FrivilligController : ControllerBase // nedarvning fra ControllerBase er meget vigtig
	{
		private readonly IFrivilligRepository Vagter = new FrivilligRepository(); // definerer en ny instans af interfacet med
                                                                                  // metoderne til CRUD funktionalitet

		public FrivilligController(IFrivilligRepository frivilligRepository)
        {
            if (Vagter == null && frivilligRepository != null)
            {
				Vagter = frivilligRepository;
				Console.WriteLine("Repository initialized");
			}
        }

		[HttpGet]
		public async Task<IEnumerable<Vagt>> GetMineVagter(int brugerId) // http get task til vagter med et specifikt brugerId
		{
			Console.WriteLine("getledigevagter - frivilligController");
			return await Vagter.GetMineVagter(brugerId);
		}

		[HttpGet("ledigevagter")]
		public async Task<IEnumerable<Vagt>> GetLedigeVagter() // http get task til vagter der er ledige
        {
			Console.WriteLine("getledigevagter - frivilligController");
			return await Vagter.GetLedigeVagter();
		}

		[HttpPost]
		public void BookVagt(int vagtId, int brugerId) // http post til booking af en vagt, bruger et brugerId og
                                                       // vagtId'et til den vagt man vil booke
		{
			Console.WriteLine("addVagt - frivilligController");
			Vagter.BookVagt(vagtId, brugerId);
		}

	}
}

