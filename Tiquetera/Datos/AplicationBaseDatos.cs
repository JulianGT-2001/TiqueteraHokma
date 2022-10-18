using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tiquetera.Models;

namespace Tiquetera.Datos
{
    public class AplicationBaseDatos : IdentityDbContext
    {
        public AplicationBaseDatos(DbContextOptions options): base(options)
        {

        }

        public DbSet<UsuariosViewModel> usuariosViewModels { get; set; }
    }    
}
