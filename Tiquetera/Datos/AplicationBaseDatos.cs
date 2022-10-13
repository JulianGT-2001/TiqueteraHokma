using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Tiquetera.Datos
{
    public class AplicationBaseDatos : IdentityDbContext
    {
        public AplicationBaseDatos(DbContextOptions options): base(options)
        {

        }
    }    
}
