using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Models;
using System;
using Newtonsoft.Json;
using System.Net;

namespace Common.Services
{

    public class UsuariosService 
    {
        private string baseUrl;
        private HttpClient client;
        public UsuariosService(string baseUrl, HttpClient client)
        {
            this.client = client;
            this.baseUrl = baseUrl;
        }

        public async Task<List<Usuario>> GetAll()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/api/Usuarios");

            var response = await client.SendAsync(request);

            var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(await response.Content.ReadAsStringAsync());

            return usuarios;
        }

        public async Task<List<Usuario>> GetByName(string name)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/api/Usuarios?name={name}");

            var response = await client.SendAsync(request);

            var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(await response.Content.ReadAsStringAsync());

            return usuarios;
        }

        public async Task<Usuario> GetById(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{baseUrl}/api/Usuarios/{id}");

            var response = await client.SendAsync(request);

            var usuario = JsonConvert.DeserializeObject<Usuario>(await response.Content.ReadAsStringAsync());

            return usuario;
        }

        public async Task<bool> Create(UsuarioCreateRequest usuarioCreateRequest)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/api/Usuarios");

            var content = JsonConvert.SerializeObject(usuarioCreateRequest);

            request.Content = new StringContent(content, null, "application/json");

            try
            {

                var response = await client.SendAsync(request);
            return response.StatusCode == HttpStatusCode.Created;
            }catch (Exception ex)
            {
                return false;
            }

        }

        public async Task<bool> Update(int id, Usuario usuario)
        {

            var request = new HttpRequestMessage(HttpMethod.Put, $"{baseUrl}/api/Usuarios/{id}");

            var content = JsonConvert.SerializeObject(usuario);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<bool> Delete(int id)
        {
            var request = new HttpRequestMessage(HttpMethod.Delete, $"{baseUrl}/api/Usuarios/{id}");

            var response = await client.SendAsync(request);

            return response.StatusCode == HttpStatusCode.NoContent;
        }

        public async Task<TokenModel> Login(LoginModel login)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, $"{baseUrl}/api/Auth/login");

            var content = JsonConvert.SerializeObject(login);

            request.Content = new StringContent(content, null, "application/json");
            var response = await client.SendAsync(request);

            var res = await response.Content.ReadAsStringAsync();

            var token = JsonConvert.DeserializeObject<TokenModel>(res);

            return token;
        }

        public class UsuarioCreateRequest
        {
            public string Nome { get; set; }
            public string Senha { get; set; }

            public UsuarioCreateRequest(string nome, string senha)
            {
                Nome = nome;
                Senha = senha;
            }
        }
    }

}