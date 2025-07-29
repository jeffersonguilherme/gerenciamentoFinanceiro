using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace GerenciamentoFinanceiro.Models;

public class Financeiro
{
    public Guid Id { get; set; }
    public string? Descricao { get; set; }
    public double Valor { get; set; }
    public DateTime DataDaOperacao { get; set; }
    public string CategoriaId { get; set; }

    [ValidateNever]
    public Categoria Categoria { get; set; }
    public string TrasacaoId { get; set; }

    [ValidateNever]
    public Transacao Transacao { get; set; }
}