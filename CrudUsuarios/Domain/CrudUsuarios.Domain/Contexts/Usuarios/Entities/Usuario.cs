namespace CrudUsuarios.Domain.Contexts.Usuarios.Entities;

public class Usuario
{
    protected Usuario() { }
    public Usuario(string nome, int idade, string email, string senha, string telefone)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
        Senha = senha;
        Telefone = telefone;
    }

    public string Nome { get; private set; }
    public int Idade { get; private set; }
    public string Email { get; private set; }
    public string Senha { get; private set; }
    public string Telefone { get; private set; }
}