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
		Task<IEnumerable<Vagt>> GetMineVagter(int brugerId); // metode til at se sine egne bookede vagter

		Task<IEnumerable<Vagt>> GetLedigeVagter(); // metode til at se alle de nuværende ledige vagter

		void BookVagt(int vagtId, int brugerId); // metode til at booke en vagt


	}
}

