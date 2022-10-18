using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tiquetera.Datos;

var builder = WebApplication.CreateBuilder(args);

//Configuramos la conexión a sql server
builder.Services.AddDbContext<AplicationBaseDatos>(opciones =>
    opciones.UseSqlServer(builder.Configuration.GetConnectionString("ConexionSQLServer"))
);

// Agregar el servicio Identity a la aplicacion
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AplicationBaseDatos>();

// Add services to the container.
builder.Services.AddControllersWithViews();
var mvc = builder.Services.AddRazorPages();
if (builder.Environment.IsDevelopment())
{
    mvc.AddRazorRuntimeCompilation();
}
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Login}/{id?}");

app.Run();
