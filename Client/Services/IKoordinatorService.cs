using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Client.Services
{
	public interface IKoordinatorService
	{
		Task<Vagt[]?> GetAlleVagter(); // metode til get på samtlige vagter

		Task<int> AddVagt(Vagt vagt); // metode til post af en ny instans af vagt klassen

		Task<int> DeleteVagt(int id); // metode til delete af en vagt, bruger et specifikt vagtId

		Task<int> UpdateVagt(int vagtId, Vagt vagt); // metode til update på en vagt, bruger et vagtId, samt en instans af vagt klassen

		Task<Bruger[]?> GetAlleFrivillige(); // metode til get af alle frivillige

		Task<int> AddOpgave(Opgave opgave); // metode til post af en ny instans af opgave klassen

	}
}

