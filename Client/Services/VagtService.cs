using System;
using System.Net.Http.Json;
using semester_projekt.Shared.Models;

namespace semester_projekt.Client.Services
{
	public class VagtService : IVagtService
	{
		private readonly HttpClient httpClient;

		public Task<Vagt[]?> GetAlleVagter()
        {
			var result = httpClient.GetFromJsonAsync<Vagt[]?>("api/vagter");
			return result;
        }

		public VagtService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}
	}
}

