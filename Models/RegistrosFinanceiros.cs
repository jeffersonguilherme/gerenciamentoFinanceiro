namespace gerenciamentoFinanceiro.Models;

public class RegistrosFinanceiros
{
    public string CategoriaNome { get; set; } = string.Empty;
    public string TransacaoNome { get; set; } = string.Empty;
    public string DataOperacao { get; set; } = string.Empty;
    public string Ganhos { get; set; } = string.Empty;
    public string Gastos { get; set; } = string.Empty;
    public string ValorCategoria { get; set; } = string.Empty;
    public string Diferenca { get; set; } = string.Empty;
}