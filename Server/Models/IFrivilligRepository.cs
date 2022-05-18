using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Server.Models
{
	public interface IFrivilligRepository
	{
		List<Vagt> GetMineVagter(); // metode til at se sine egne bookede vagter

		List<Vagt> GetLedigeVagter(); // metode til at se alle de nuværende ledige vagter

		void BookVagt(Vagt vagt); // metode til at booke en vagt


	}
}

