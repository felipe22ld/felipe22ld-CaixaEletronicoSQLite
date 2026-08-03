using CaixaEletronico.Models;

namespace CaixaEletronico.Interfaces;

public interface IUsuarioRepositorio
{
    void CriarConta(Conta conta);

    Conta BuscarConta(int numero);

    void AtualizarSaldo(Conta conta);

    List<Conta> Listar();
}   