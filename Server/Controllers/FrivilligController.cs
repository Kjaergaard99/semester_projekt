using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using semester_projekt.Shared.Models;
using semester_projekt.Server.Models;


namespace semester_projekt.Server.Controllers
{
	[ApiController]
	[Route("api/ledigevagter")]
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
		public IEnumerable<Vagt> GetLedigeVagter()
        {
			Console.WriteLine("getledigevagter - controller");
			return Vagter.GetLedigeVagter();
		}



	}
}

