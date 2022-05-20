using System;
using System.Net.Http.Json;
using semester_projekt.Shared.Models;
using Dapper;
using Npgsql;

namespace semester_projekt.Client.Services
{
	public class KoordinatorService : IKoordinatorService
	{
        private readonly HttpClient httpClient;

        public Task<Vagt[]?> GetAlleVagter()
        {
            var result = httpClient.GetFromJsonAsync<Vagt[]>("api/koordinator");
            return result;
        }

        public async Task<int> AddVagt(Vagt vagt)
        {
            var response = await httpClient.PostAsJsonAsync("api/koordinator", vagt);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> UpdateVagt(int vagtId, Vagt vagt)
        {
            var response = await httpClient.PostAsJsonAsync("api/koordinator", vagtId, vagt); // hvad skal der stå her?
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public async Task<int> DeleteVagt(int vagtId)
        {
            var response = await httpClient.PostAsJsonAsync("api/koordinator", vagtId); // hvad skal der stå her?
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public Task<Bruger[]?> GetAlleFrivillige()
        {
            var result = httpClient.GetFromJsonAsync<Bruger[]>("api/koordinator");
            return result;
        }

        public async Task<int> AddOpgave(Opgave opgave)
        {
            var response = await httpClient.PostAsJsonAsync("api/koordinator", opgave);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }

        public KoordinatorService()
		{
		}
	}
}

