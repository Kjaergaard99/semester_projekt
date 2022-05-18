/*
using System;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using semester_projekt.Shared.Models;
using semester_projekt.Server.Models;

namespace semester_projekt.Server.Controllers
{
	public class KoordinatorController : ControllerBase
	{
		private readonly IBrugerRepository Repository = new BrugerRepository();


		public KoordinatorController(IBrugerRepository brugerRepository)
		{
			if (Repository == null && brugerRepository != null)
			{
				Repository = brugerRepository;
				Console.WriteLine("Repository initialized");
			}
		}

		[HttpGet]
		public IEnumerable<BrugerDTO> GetAllItems()
		{
			Console.WriteLine("getallitems - controller");
			return Repository.GetAllItems();
		}
	}
}

*/