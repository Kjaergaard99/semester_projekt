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
		Task<IEnumerable<Vagt>> GetAlleVagter(); // metode til get alle vagter i systemet

		void AddVagt(Vagt vagt); // metode til at poste en ny vagt

		void UpdateVagt(int vagtId, Vagt vagt); // metode til at update en vagt

		void DeleteVagt(int id); // metode til delete af en vagt

		Task<IEnumerable<Bruger>> GetAlleFrivillige(); // task til at hente alle frivillige i systemet

		void AddOpgave(Opgave opgave); // metode til post af en ny opgave

	}
}

