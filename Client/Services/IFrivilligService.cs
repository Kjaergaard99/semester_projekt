using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Client.Services
{
	public interface IFrivilligService
	{
		Task<Vagt[]?> GetLedieVagter();

		Task<int> BookVagt(Vagt vagt);

		Task<Vagt[]?> GetMineVagter();

	}
}

