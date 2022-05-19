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
	public interface IFrivilligRepository
	{
		// List<Vagt> GetMineVagter(); // metode til at se sine egne bookede vagter

		// List<Vagt> GetLedigeVagter(); // metode til at se alle de nuværende ledige vagter

		void BookVagt(Vagt vagt); // metode til at booke en vagt


	}
}

