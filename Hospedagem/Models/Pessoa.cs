namespace DesafioProjetoHospedagem.Models;

public class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public Pessoa(string nome) : this(nome, string.Empty) { } // Construtor opcional

    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}