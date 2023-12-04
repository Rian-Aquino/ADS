
using Common.Utils;
using Microsoft.AspNetCore.Http;

namespace Common.Services
{
    public static class HttpResponseExtension
    {
        private static CookieOptions cookieOptions = new CookieOptions
        {
            Expires = DateTime.Now.AddHours(3),
            HttpOnly = true
        };

        public static void SaveTokenCookie(this HttpResponse Response, string token)
        {
            Response.Cookies.Append("token", $"Bearer {token}", cookieOptions);
        }

        public static void ClearTokenCookie(this HttpResponse Response)
        {
            Response.Cookies.Append("token", "");
        }

    }

    public static class HttpRequestExtension
    {
        public static string GetToken(this HttpRequest Request)
        {
            return Request.Cookies["token"];
        } 
        
        public static int GetTokenUserId(this HttpRequest Request)
        {
            string? token = Request.Cookies["token"];

            return token == null ? throw new ArgumentNullException("token") : int.Parse(TokenUtils.GetUserIdFromToken(token));
        }
    }

}