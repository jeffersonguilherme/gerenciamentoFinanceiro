using System.ComponentModel.DataAnnotations;

namespace gerenciamentoFinanceiro.Models;

public class Categoria
{
    public string CategoriaId { get; set; } = string.Empty;

    [Required(ErrorMessage = "Digite a categoria!")]
    public string Nome { get; set; }= string.Empty;
}