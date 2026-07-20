using CaixaEletronico.Aplicacao;
using CaixaEletronico.Interfaces;
using CaixaEletronico.Repositorios;

IUsuarioRepositorio usuarioRepositorio = new UsusariosRepositorio();
var aplicacao = new AppUsuarioAplicacao(usuarioRepositorio);

aplicacao.Executar();