using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace gerenciamentoFinanceiro.Models;

public class Financeiro
{
    public int Id { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public double Valor { get; set; }
    public DateTime DataDaOperacao { get; set; }
    public string CategoriaId { get; set; }

    [ValidateNever]
    public Categoria Categoria { get; set; }
    public string TransacaoId { get; set; }
    
    [ValidateNever]
    public Transacao Transacao { get; set; }
}