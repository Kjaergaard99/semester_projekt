using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Client.Services
{
	public interface IFrivilligService
	{
		Task<Vagt[]?> GetLedigeVagter();

		Task<Vagt[]?> GetMineVagter();

		Task<int> BookVagt(Vagt vagt);
	}
}
