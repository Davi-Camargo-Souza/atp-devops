using CrudUsuarios.Domain.Contexts.Usuarios.Entities;
using CrudUsuarios.Domain.Contexts.Usuarios.Repositories;

namespace CrudUsuarios.Infrastructure.Contexts.Usuarios.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    public Usuario Criar(Usuario usuario)
    {
        // Simulação de criação de usuário
        return usuario;
    }
}