using CaixaEletronico.Interfaces;
using CaixaEletronico.Models;

namespace CaixaEletronico.Repositorios;

public class UsusariosRepositorio : IUsuarioRepositorio
{
    private readonly List<Conta> _usuarios = [];

    public void Cadastrar()
    {
        var nome = LerNome();
        var usuario = new Conta(
            GerarProximoId(),
            nome,
            0
        );
    }

    private static string LerNome()
    {
        while (true)
        {
            Console.Write("Nome:  ");
            var nome = Console.ReadLine()?.Trim();
            if (!string.IsNullOrWhiteSpace(nome))
            {
                return nome;
            }

            Console.WriteLine("O nome é obrigatório!");
            Console.WriteLine();
        }
    }

    private static DateOnly LerDataDeNascimento()
    {
        while (true)
        {
            Console.Write("Data de Nascimento (dd/mm/yyyy):");
            var data = Console.ReadLine();

            if (DateOnly.TryParse(data, out var dataNascimento))
            {
                return dataNascimento;
            }

            Console.WriteLine("Data de nascimento inválida.");
            Console.WriteLine();
        }
    }

    private int GerarProximoId()
    {
        if (_usuarios.Count == 0)
        {
            return 1;
        }

        var id = _usuarios.Max(u => u.Id) + 1;
        return id;
    }

    public void CriarConta(Conta conta)
    {
        throw new NotImplementedException();
    }

    public Conta BuscarConta(int numero)
    {
        throw new NotImplementedException();
    }

    public void AtualizarSaldo(Conta conta)
    {
        throw new NotImplementedException();
    }

    public List<Conta> Listar()
    {
        throw new NotImplementedException();
    }
}