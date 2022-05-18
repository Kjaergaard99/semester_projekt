using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Server.Models
{
	public interface IFrivilligRepository
	{
		List<Vagt> GetMineVagter();

		List<Vagt> GetLedigeVagter();

		void BookVagt(Vagt vagt);


	}
}

