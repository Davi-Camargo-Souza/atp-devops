namespace CrudUsuarios.Domain.Contexts.Usuarios.Entities;

public class Usuario
{
    protected Usuario() { }
    public Usuario(Guid id, string nome, int idade, string email, string senha, string telefone)
    {
        Id = id;
        Nome = nome;
        Idade = idade;
        Email = email;
        Senha = senha;
        Telefone = telefone;
        Validate();
    }

    private void Validate()
    {
        if (string.IsNullOrWhiteSpace(Nome))
            throw new ArgumentException("Nome não pode ser vazio.");
        
        if (Nome.Length < 3)
            throw new ArgumentException("Nome deve ter pelo menos 3 caracteres.");
        
        if (Idade < 0)
            throw new ArgumentException("Idade não pode ser negativa.");
        
        if (string.IsNullOrEmpty(Email) || !Email.Contains("@"))
            throw new ArgumentException("Email inválido.");
        
        if (string.IsNullOrWhiteSpace(Senha) || Senha.Length < 6)
            throw new ArgumentException("Senha deve ter pelo menos 6 caracteres.");
    }

    public Guid Id { get; private set; }
    public string Nome { get; private set; } = null!;
    public int Idade { get; private set; }
    public string Email { get; private set; } = null!;
    public string Senha { get; private set; } = null!;
    public string Telefone { get; private set; } = null!;
}