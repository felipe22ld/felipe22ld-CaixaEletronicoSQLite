namespace CaixaEletronico.Models;

public class Usuario
{


    public int Id { get; private set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }
    public string ChavePix { get; set; }
    public DateOnly DataNascimento { get; set; }
    public DateTime ContaCriadaEm { get; set; }
    public string Banco { get; set; }
    
    public  decimal Saldo { get; set; }
    
    public Usuario(
        int id, 
        string nome, 
        string sobrenome, 
        string cpf, 
        string telefone, 
        string chavePix, 
        DateOnly dataNascimento, 
        DateTime contaCriadaEm, 
        string banco, 
        decimal saldo)
    {
        Id = id;
        Nome = nome;
        Sobrenome = sobrenome;
        Cpf = cpf;
        Telefone = telefone;
        ChavePix = chavePix;
        DataNascimento = dataNascimento;
        ContaCriadaEm = contaCriadaEm;
        Banco = banco;
        Saldo = saldo;
    }
}