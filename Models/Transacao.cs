namespace CaixaEletronico.Models;

public class Conta
{
    public int Id { get; private set; }

    public string Tipo { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataDaTransacao { get; set; }
    public int ContaOrigem { get; set; }
    public string ContaDestino { get; set; }

    public Conta(
        int id,
        string tipo,
        decimal valor,
        DateTime dataDaTransacao,
        int contaOrigem,
        string contaDestino
    )
    {
        Id = id;
        Tipo = tipo;
        Valor = valor;
        DataDaTransacao = dataDaTransacao;
        ContaOrigem = contaOrigem;
        ContaDestino = contaDestino;
    }
}