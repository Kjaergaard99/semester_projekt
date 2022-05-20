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
	public interface IKoordinatorRepository
	{
		Task<IEnumerable<Vagt>> GetAlleVagter();

		void AddVagt(Vagt vagt);

		void UpdateVagt(int vagtId, Vagt vagt);

		void DeleteVagt(int id);

		Task<IEnumerable<Bruger>> GetAlleFrivillige();

		void AddOpgave(Opgave opgave);

	}
}

