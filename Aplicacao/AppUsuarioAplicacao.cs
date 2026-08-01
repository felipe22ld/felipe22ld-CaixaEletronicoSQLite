using CaixaEletronico.Interfaces;
using CaixaEletronico.Menu;

namespace CaixaEletronico.Aplicacao;

public class AppUsuarioAplicacao
{
    private readonly IUsuarioRepositorio _usuarioRepositorio;
    private readonly ITransacaoRepositorio _transacaoRepositorio;

    public AppUsuarioAplicacao(IUsuarioRepositorio usuarioRepositorio, ITransacaoRepositorio transacaoRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
        _transacaoRepositorio = transacaoRepositorio;
    }

    public void Executar()
    {
        var executando = true;

        while (executando)
        {
            Menu.Menu.Exibir();

            Console.WriteLine("Escolha uma opção");
            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    _usuarioRepositorio.Cadastrar();
                    break;
                case "2":
                    _usuarioRepositorio.Depositar();
                    break;
                case "3":
                    _usuarioRepositorio.Editar();
                    break;
                case "4":
                    _usuarioRepositorio.Excluir();
                    break;
                case "5":
                    executando = false;
                    break;
                default:
                    ExibirOpcaoInvalida();
                    break;
            }
        }
    }

    private void ExibirOpcaoInvalida()
    {
        Console.Clear();
        Console.WriteLine("Opção inválida!");
        Console.WriteLine();
        Console.WriteLine("Precione qualquer tecla para continuar");
        Console.ReadKey();
    }
}