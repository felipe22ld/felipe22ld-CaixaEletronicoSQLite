namespace CaixaEletronico.Interfaces;

public interface ITransacaoRepositorio
{
    void Depositar();
    void Sacar();
    void Transferir();
    void ConsultarSaldo();
    void ConsultarHistorico();
}