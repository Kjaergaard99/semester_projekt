using System;
using semester_projekt.Shared.Models;

namespace semester_projekt.Server.Models
{
	public interface IKoordinatorRepository
	{
		List<Vagt> GetAlleVagter();

		void AddVagt(Vagt vagt);

		void UpdateVagt(int id);

		void DeleteVagt(int id);

		List<Vagt> GetAlleFrivillige();

	}
}

