using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace gerenciamentoFinanceiro.Models;

public class Financeiro
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Digite uma descrição!")]
    public string Descricao { get; set; } = string.Empty;

    [Required(ErrorMessage = "Digite um valor!")]

    public double Valor { get; set; }

    [Required(ErrorMessage = "Digite uma data!")]
    public DateTime DataDaOperacao { get; set; }

    [Required(ErrorMessage = "Selecione uma categoria!")]
    public string CategoriaId { get; set; }

    [ValidateNever]
    public Categoria Categoria { get; set; }
    
    [Required(ErrorMessage = "Selecione uma transação!")]
    public string TransacaoId { get; set; }
    
    [ValidateNever]
    public Transacao Transacao { get; set; }
}