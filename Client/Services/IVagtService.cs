using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Client.Services
{
	public interface IVagtService
	{
		Task<Vagt[]?> GetAlleVagter();


	}
}

