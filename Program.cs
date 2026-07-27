using CaixaEletronico.Aplicacao;
using CaixaEletronico.Interfaces;
using CaixaEletronico.Repositorios;

IUsuarioRepositorio usuarioRepositorio = new UsusariosRepositorio();
ITransacaoRepositorio transacaoRepositorio = new TransacaoRepositorio();
var aplicacao = new AppUsuarioAplicacao(usuarioRepositorio, transacaoRepositorio);

aplicacao.Executar();