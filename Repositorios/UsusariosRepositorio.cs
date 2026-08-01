using CaixaEletronico.Interfaces;
using CaixaEletronico.Models;

namespace CaixaEletronico.Repositorios;

public class UsusariosRepositorio : IUsuarioRepositorio
{
    private readonly List<Usuario> _usuarios = [];

    public void Cadastrar()
    {
        var nome = LerNome();
        // var sobreNomenome = LerSobreNome();
        // var dataDeNascimento = LerDataDeNascimento();
        // var cpf = LerCpf();
        // var telefone = LerTelefone();
        // var chavePix = LerChavePix();

        var usuario = new Usuario(
            GerarProximoId(),
            nome,
            // sobreNomenome,
            // cpf,
            // telefone,
            // chavePix,
            // dataDeNascimento,
            // new DateTime(),
            // "inter",
            0
        );

        _usuarios.Add(usuario);
        Console.WriteLine($"Conta criada com sucesso! Id da conta: {usuario.Id}");
    }

    public void Exibir()
    {
        if (_usuarios.Count == 0)
        {
            Console.WriteLine("Nenhuma conta cadastrada.");
            return;
        }

        Console.WriteLine("Contas disponíveis:");
        foreach (var usuario in _usuarios)
        {
            Console.WriteLine($"Id: {usuario.Id} | Nome: {usuario.Nome} | Saldo: {usuario.Saldo:C}");
        }
    }

    public void Editar()
    {
        throw new NotImplementedException();
    }

    public void Excluir()
    {
        throw new NotImplementedException();
    }

    public void Depositar()
    {
        if (_usuarios.Count == 0)
        {
            Console.WriteLine("Nenhuma conta cadastrada para depósito.");
            return;
        }

        Exibir();
        var idConta = LerIdConta();
        var conta = _usuarios.FirstOrDefault(usuario => usuario.Id == idConta);

        if (conta is null)
        {
            Console.WriteLine("Conta não encontrada.");
            return;
        }

        var valor = LerValor();
        conta.Saldo += valor;
        Console.WriteLine($"Depósito realizado! Novo saldo da conta {conta.Id}: {conta.Saldo:C}");
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

    private static string LerSobreNome()
    {
        while (true)
        {
            Console.Write("Sobrenome:  ");
            var sobreNome = Console.ReadLine()?.Trim();
            if (!string.IsNullOrWhiteSpace(sobreNome))
            {
                return sobreNome;
            }

            Console.WriteLine("O sobrenome é obrigatório!");
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

    private static string LerCpf()
    {
        while (true)
        {
            Console.Write("CPF (somente números)  ex.:0123456789: ");
            var cpf = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(cpf))
            {
                return cpf;
            }

            Console.WriteLine("Insira um CPF.");
            Console.WriteLine();
        }
    }

    private string LerTelefone()
    {
        while (true)
        {
            Console.Write("Telefone (com DDD) ex.:21999999999:");
            var telefone = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(telefone))
            {
                return telefone;
            }

            Console.WriteLine("Insira um Telefone.");
            Console.WriteLine();
        }
    }

    private string LerChavePix()
    {
        while (true)
        {
            Console.WriteLine("Ecolha uma opção para chave pix");
            Console.WriteLine("1 - Telefone");
            Console.WriteLine("2 - CPF");
            var chavePix = Console.ReadLine();

            if (chavePix == "1")
            {
                Console.WriteLine("Telefone escolhido com sucesso!");
            }
            else if (chavePix == "2")
            {
                Console.WriteLine("CPF escolhido com sucesso!");
            }
            else
            {
                Console.WriteLine("Selecione uma opção válida");
            }

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

    private static int LerIdConta()
    {
        while (true)
        {
            Console.Write("Digite o Id da conta para depósito: ");
            var entrada = Console.ReadLine();

            if (int.TryParse(entrada, out var idConta) && idConta > 0)
            {
                return idConta;
            }

            Console.WriteLine("Digite um Id válido.");
            Console.WriteLine();
        }
    }

    private static decimal LerValor()
    {
        while (true)
        {
            Console.Write("Digite o valor para depósito: ");
            var entrada = Console.ReadLine();

            if (decimal.TryParse(entrada, out var valorDeposito) && valorDeposito > 0)
            {
                return valorDeposito;
            }

            Console.WriteLine("Digite um valor maior que zero.");
            Console.WriteLine();
        }
    }
}