using System.ComponentModel.DataAnnotations;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TP03.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do produto é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do produto é obrigatória.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O preço do produto é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória.")]
        [Range(0, int.MaxValue, ErrorMessage = "A quantidade não pode ser negativa.")]
        public int QuantidadeEmEstoque { get; set; }
    }
}
