﻿namespace API.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public float Preco { get; set; }
        public bool Status { get; set; }
        public int IdUsuarioCadastro { get; set; }
        public int IdUsuarioUpdate { get; set; }
    }
}
