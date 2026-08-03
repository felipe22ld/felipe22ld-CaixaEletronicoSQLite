using CaixaEletronico.Models;

namespace CaixaEletronico.Interfaces;

public interface IContaRepositorio
{
    void Registrar(Transacao transacao);

    List<Transacao> BuscarPorConta(int numeroConta);
    
    
    
    
    void AdicionarConta(Conta conta);
    Conta? ObterContaPorNumero(string numero);
    void AtualizarConta(Conta conta);
}