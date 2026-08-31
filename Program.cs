using CRUDProductos.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// =====================================================
// CONFIGURACIÓN DE SERVICIOS
// =====================================================

// ASP.NET Core MVC
builder.Services.AddControllersWithViews();

// =====================================================
// ENTITY FRAMEWORK CORE + MYSQL
// =====================================================

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    );
});

// =====================================================
// CONSTRUCCIÓN DE LA APLICACIÓN
// =====================================================

var app = builder.Build();

// =====================================================
// CONFIGURACIÓN DEL PIPELINE HTTP
// =====================================================

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// HTTPS
app.UseHttpsRedirection();

// Archivos estáticos
app.UseStaticFiles();

// Routing
app.UseRouting();

// Autorización
app.UseAuthorization();

// =====================================================
// RUTAS MVC
// =====================================================

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Productos}/{action=Index}/{id?}"
);

// =====================================================
// EJECUTAR APLICACIÓN
// =====================================================

app.Run();