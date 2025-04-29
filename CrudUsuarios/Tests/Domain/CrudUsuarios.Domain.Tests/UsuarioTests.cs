using System.ComponentModel;
using CrudUsuarios.Domain.Contexts.Usuarios.Entities;

namespace CrudUsuarios.Domain.Tests;

public class UsuarioTests
{
    private readonly Guid _id;
    private readonly string _nome;
    private readonly int _idade;
    private readonly string _telefone;
    private readonly string _email;
    private readonly string _senha;

    public UsuarioTests()
    {
        _id = Guid.NewGuid();
        _nome = "Nome Teste";
        _idade = 25;
        _telefone = "(11) 91234-5678";
        _email = "email@gmail.com";
        _senha = "Senha123";
    }


    [DisplayName("Deve estourar ArgumentException quando o Nome for vazio ou nulo")]
    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(null)]
    public void DeveEstourarArgumentExceptionQuandoNomeForVazioOuNulo(string nome)
        => Assert.Throws<ArgumentException>(
            () => new Usuario(
                    _id,
                    nome,
                    _idade,
                    _email,
                    _senha,
                    _telefone));
    
    [DisplayName("Deve estourar ArgumentException quando o Nome tiver menos de 3 caracteres")]
    [Theory]
    [InlineData("a")]
    [InlineData("aa")]
    public void DeveEstourarArgumentExceptionQuandoNomeTiverMenosDe3Caracteres(string nome)
        => Assert.Throws<ArgumentException>(
            () => new Usuario(
                _id,
                nome,
                _idade,
                _email,
                _senha,
                _telefone));
    
    [DisplayName("Deve estourar ArgumentException quando a Senha for vazia ou nula")]
    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(null)]
    public void DeveEstourarArgumentExceptionQuandoASenhaForVaziaOuNula(string senha)
        => Assert.Throws<ArgumentException>(
            () => new Usuario(
                _id,
                _nome,
                _idade,
                _email,
                senha,
                _telefone));
    
    [DisplayName("Deve estourar ArgumentException quando a Senha tiver menos de 6 caracteres")]
    [Theory]
    [InlineData("a")]
    [InlineData("aa")]
    [InlineData("aaa")]
    [InlineData("aaaa")]
    [InlineData("aaaaa")]
    public void DeveEstourarArgumentExceptionQuandoASenhaTiverMenosDe6Caracteres(string senha)
        => Assert.Throws<ArgumentException>(
            () => new Usuario(
                _id,
                _nome,
                _idade,
                _email,
                senha,
                _telefone));
    
    [DisplayName("Deve estourar ArgumentException quando a Idade for negativa")]
    [Theory]
    [InlineData(-1)]
    [InlineData(-10)]
    public void DeveEstourarArgumentExceptionQuandoAIdadeForNegativa(int idade)
        => Assert.Throws<ArgumentException>(
            () => new Usuario(
                _id,
                _nome,
                idade,
                _email,
                _senha,
                _telefone));
}