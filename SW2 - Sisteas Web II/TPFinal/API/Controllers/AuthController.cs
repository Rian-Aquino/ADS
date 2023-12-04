using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API.Models;
using System.Security.Principal;
using API.Security;
using Microsoft.EntityFrameworkCore;
using API.Data;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly APIContext _context;

        public AuthController(APIContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (login == null)
            {
                return BadRequest("Credenciais inválidas.");
            }

            var usuario = _context.Usuario.FirstOrDefault(u => u.Nome == login.Login && u.Senha == login.Senha && u.Status == true);

            if (usuario == null)
            {
                return Unauthorized("Credenciais inválidas.");
            }

            return Ok(TokenService.GenerateToken(usuario));

        }
    }
}
