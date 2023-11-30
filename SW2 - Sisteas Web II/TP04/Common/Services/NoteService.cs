using Common.Dtos;
using Common.Models;
using Newtonsoft.Json;
using System.Net;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace Common.Services
{
    public class NoteService
    {
        private string baseUrl;
        private HttpClient client;
        public NoteService(string baseUrl, HttpClient client)
        {
            this.client = client;
            this.baseUrl = baseUrl;
        }

        public async Task<List<Note>> GetAll()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/Notes");

            var response = await client.SendAsync(request);

            var notes = JsonConvert.DeserializeObject<List<Note>>(await response.Content.ReadAsStringAsync());
            return notes;
        }

        public async Task<Note> GetById(long id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/Notes/{id}");

            var response = await client.SendAsync(request);

            var note = JsonConvert.DeserializeObject<Note>(await response.Content.ReadAsStringAsync());

            return note;
        }

        public async Task<bool> Create(NoteRequest note)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/Notes");

            var content = JsonConvert.SerializeObject(note);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task<bool> Update(long id, Note note)
        {
            var request = new HttpRequestMessage(HttpMethod.Put, $"{baseUrl}/Notes/{id}");

            var content = JsonConvert.SerializeObject(note);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<bool> Delete(long id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{baseUrl}/Notes/{id}");

            var response = await client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.NoContent;
        }

    }
}