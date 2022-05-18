using System;
using System.Net.Http.Json;
using semester_projekt.Shared.Models;

namespace semester_projekt.Client.Services
{
    public class FrivilligService : IFrivilligService
    {
        private readonly HttpClient httpClient;

        public Task<Vagt[]?> GetMineVagter()
        {
            var result = httpClient.GetFromJsonAsync<Vagt[]>("api/brugervagter");
            return result;
        }

        public Task<Vagt[]?> GetLedieVagter()
        {
            var result = httpClient.GetFromJsonAsync<Vagt[]>("api/ledigevagter");
            return result;
        }

        public async Task<int> BookVagt(Vagt vagt)
        {
            var response = await httpClient.PostAsJsonAsync("api/brugervagter", vagt);
            var responseStatusCode = response.StatusCode;
            return (int)responseStatusCode;
        }


        public FrivilligService()
        {
        }
    }
}

