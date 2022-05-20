using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Client.Services
{
	public interface IKoordinatorService
	{
		Task<Vagt[]?> GetAlleVagter();

		Task<int> AddVagt(Vagt vagt);

		Task<int> DeleteVagt(int id);

		Task<int> UpdateVagt(int vagtId, Vagt vagt);

		Task<Bruger[]?> GetAlleFrivillige();

		Task<int> AddOpgave(Opgave opgave);

	}
}

