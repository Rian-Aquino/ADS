using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Common.Services;
using NuGet.Common;

namespace Common.Services
{
    public class ProdutosService
    {
        private string baseUrl;
        private HttpClient client;
        public ProdutosService(string baseUrl, HttpClient client)
        {
            this.client = client;
            this.baseUrl = baseUrl;
        }

        public async Task<List<Produto>> GetAll(string token)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/api/Produtos");

            request.Headers.Add("Authorization", token);

            var response = await client.SendAsync(request);

            var produtos = JsonConvert.DeserializeObject<List<Produto>>(await response.Content.ReadAsStringAsync());

            return produtos;
        }

        public async Task<Produto> GetById(int id, string token)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/api/Produtos/{id}");

            request.Headers.Add("Authorization", token);

            var response = await client.SendAsync(request);

            var produto = JsonConvert.DeserializeObject<Produto>(await response.Content.ReadAsStringAsync());

            return produto;
        }

        public async Task<bool> Create(Produto produto, int userId, string token)
        {
            produto.IdUsuarioCadastro = userId;
            produto.IdUsuarioUpdate = userId;

            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/api/Produtos");

            request.Headers.Add("Authorization", token);

            var content = JsonConvert.SerializeObject(produto);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.Created;
        }

        public async Task<bool> Update(int id, Produto produto, int userId, string token)
        {
            produto.IdUsuarioUpdate = userId;

            var request = new HttpRequestMessage(HttpMethod.Put, $"{baseUrl}/api/Produtos/{id}");

            request.Headers.Add("Authorization", token);

            var content = JsonConvert.SerializeObject(produto);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<bool> Delete(int id, string token)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{baseUrl}/api/Produtos/{id}");

            request.Headers.Add("Authorization", token);

            var response = await client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.NoContent;
        }

    }
}
