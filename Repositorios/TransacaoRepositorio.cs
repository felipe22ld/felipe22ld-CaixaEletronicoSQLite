using CaixaEletronico.Interfaces;
using CaixaEletronico.Models;

namespace CaixaEletronico.Repositorios;

public class ContaRepositorio : IContaRepositorio
{
    private readonly List<Transacao> _transacoes = [];

    public void Depositar()
    {
        var valor = LerValor();
        var tipo = "deposito";
        var contaDestinatario = LerContaDestinatario();

        var transacao = new Transacao(
            GerarProximoId(),
            tipo,
            valor,
            new DateTime(),
            // usuario,
            contaDestinatario
        );
    }

    private int GerarProximoId()
    {
        if (_transacoes.Count == 0)
        {
            return 1;
        }

        var id = _transacoes.Max(u => u.Id) + 1;
        return id;
    }


    private object LerTipo()
    {
        throw new NotImplementedException();
    }

    public void Sacar()
    {
        throw new NotImplementedException();
    }

    public void Transferir()
    {
        throw new NotImplementedException();
    }

    public void ConsultarSaldo()
    {
        throw new NotImplementedException();
    }

    public void ConsultarHistorico()
    {
        throw new NotImplementedException();
    }

    private decimal LerValor()
    {
        while (true)
        {
            Console.Write("Digite o valor para depósito: ");
            var entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out decimal valorDeposito) && valorDeposito > 0)
            {
                return valorDeposito;
            }

            Console.WriteLine("Digite um valor maior que zero.");
            Console.WriteLine();
        }
    }

    private static string LerContaDestinatario()
    {
        while (true)
        {
            Console.Write("Digite o valor para depósito: ");
            var entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out decimal valorDeposito) && valorDeposito > 0)
            {
                return null;
            }

            Console.WriteLine("Digite um valor maior que zero.");
            Console.WriteLine();
        }
    }

    public void Registrar(Transacao transacao)
    {
        throw new NotImplementedException();
    }

    public List<Transacao> BuscarPorConta(int numeroConta)
    {
        throw new NotImplementedException();
    }
}