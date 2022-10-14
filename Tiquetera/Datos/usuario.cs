using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tiquetera.Datos
{
    public class usuario : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(254)")]
        public string minombre { get; set; }
    }
}
