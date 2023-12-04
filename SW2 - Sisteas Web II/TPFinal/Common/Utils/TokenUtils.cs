using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Utils
{
    public class TokenUtils
    {
        public static string GetUserIdFromToken(string token)
        {
            string[] tokenParts = token.Split('.');


            if (tokenParts.Length < 3)
            {
                throw new InvalidOperationException("Token JWT inválido.");
            }

            // Decode a parte do conteúdo (payload)
            string payload = Base64UrlDecode(tokenParts[1]);

            // Deserialize o JSON
            var payloadData = JsonConvert.DeserializeObject<TokenPayload>(payload);

            // Obtenha o ID do usuário (ou outra informação desejada)
            return payloadData.UsuarioId;
        }

        private static string Base64UrlDecode(string input)
        {
            input = input.PadRight((input.Length + 3) & ~3, '=');
            input = input.Replace('-', '+').Replace('_', '/');
            byte[] buffer = Convert.FromBase64String(input);

            return Encoding.UTF8.GetString(buffer);
        }

        private class TokenPayload
        {
            public string UsuarioId { get; set; }
        }
    }
}
