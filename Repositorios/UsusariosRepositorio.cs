using CaixaEletronico.Interfaces;
using CaixaEletronico.Models;

namespace CaixaEletronico.Repositorios;

public class UsusariosRepositorio : IUsuarioRepositorio
{
    private readonly List<Usuario> _usuarios = [];

    public void Cadastrar()
    {
        var nome = LerNome();
        var sobreNomenome = LerSobreNome();
        var dataDeNascimento = LerDataDeNascimento();
        var cpf = LerCpf();
        var telefone = LerTelefone();
        var chavePix = LerChavePix();

        var usuario = new Usuario(
            GerarProximoId(),
            nome,
            sobreNomenome,
            cpf,
            telefone,
            chavePix,
            dataDeNascimento,
            new DateTime(),
            "inter",
            0
        );
    }

    // int id, 
    // string nome, 
    // string sobrenome, 
    // long cpf, 
    // long telefone, 
    // int chavePix, 

    //     DateOnly dataNascimento, 
    // DateTime contaCriadaEm, 
    // string banco, 
    // decimal saldo)


    public void Exibir()
    {
        throw new NotImplementedException();
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

    private static string LerNome()
    {
        while (true)
        {
            Console.WriteLine("Nome:  ");
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
            Console.WriteLine("Sobrenome:  ");
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
            Console.WriteLine("Data de Nascimento: (dd/mm/yyyy) ");
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
            Console.WriteLine("CPF (somente números): XXXXXXXXXXXX ");
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
            Console.WriteLine("Telefone (com DDD): (XX) XXXXX XXXX");
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
}