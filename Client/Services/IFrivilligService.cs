using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Client.Services
{
	public interface IFrivilligService
	{
		Task<Vagt[]?> GetLedigeVagter(); // metode til get på alle ledige vagter

		Task<Vagt[]?> GetMineVagter(); // metode til get på alle ledige vagter

		Task<int> BookVagt(Vagt vagt); // metode til booking af en vagt
	}
}
