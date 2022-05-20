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

	public class FrivilligController : ControllerBase
	{
		private readonly IFrivilligRepository Vagter = new FrivilligRepository();

		public FrivilligController(IFrivilligRepository frivilligRepository)
        {
            if (Vagter == null && frivilligRepository != null)
            {
				Vagter = frivilligRepository;
				Console.WriteLine("Repository initialized");
			}
        }

		[HttpGet]
		public async Task<IEnumerable<Vagt>> GetMineVagter(int brugerId)
		{
			Console.WriteLine("getledigevagter - frivilligController");
			return await Vagter.GetMineVagter(brugerId);
		}

		[HttpGet]
		public async Task<IEnumerable<Vagt>> GetLedigeVagter()
        {
			Console.WriteLine("getledigevagter - frivilligController");
			return await Vagter.GetLedigeVagter();
		}

		[HttpPost]
		public void BookVagt(int vagtId, int brugerId)
		{
			Console.WriteLine("addVagt - frivilligController");
			Vagter.BookVagt(vagtId, brugerId);
		}

	}
}

