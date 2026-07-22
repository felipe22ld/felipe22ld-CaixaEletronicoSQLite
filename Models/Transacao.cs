namespace CaixaEletronico.Models;

public class Transacao
{
    public string Tipo { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataDaTransacao { get; set; }
    public Usuario Usuario { get; set; }
    public string ContaDestinatario { get; set; }

    public Transacao(
        string tipo,
        decimal valor,
        DateTime dataDaTransacao,
        Usuario usuario,
        string contaDestinatario
    )
    {
        Tipo = tipo;
        Valor = valor;
        DataDaTransacao = dataDaTransacao;
        Usuario = usuario;
        ContaDestinatario = contaDestinatario;
    }
}