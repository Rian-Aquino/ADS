namespace API.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

        public Usuario() { }
        public Usuario(int id, string nome, string senha, bool status)
        {
            Id = id;
            Nome = nome;
            Senha = senha;
            Status = status;
        }
    }
}
