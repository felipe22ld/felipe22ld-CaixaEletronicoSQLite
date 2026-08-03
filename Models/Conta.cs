namespace CaixaEletronico.Models;

public class Usuario
{
    public int Id { get; private set; }
    public string Nome { get; set; }
    public  decimal Saldo { get; set; }
    
    public Usuario(
        int id, 
        string nome, 
        decimal saldo)
    {
        Id = id;
        Nome = nome;
        Saldo = saldo;
    }
}