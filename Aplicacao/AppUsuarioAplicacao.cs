using CaixaEletronico.Interfaces;
using CaixaEletronico.Menu;

namespace CaixaEletronico.Aplicacao;

public class AppUsuarioAplicacao
{
    private readonly IUsuarioRepositorio _usuarioRepositorio;

    public AppUsuarioAplicacao(IUsuarioRepositorio usuarioRepositorio)
    {
        _usuarioRepositorio = usuarioRepositorio;
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
                    _usuarioRepositorio.Exibir();
                    break;
                case "3":
                    _usuarioRepositorio.Editar();
                    break;
                case "4":
                    _usuarioRepositorio.Excluir();
                    break;
                default:
                    ExibirOpcaoInvalida();
                    break;
            }

            executando = false;
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