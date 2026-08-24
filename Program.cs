using CRUDProductos.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// =====================================================
// Configuración de servicios
// =====================================================

// MVC
builder.Services.AddControllersWithViews();

// =====================================================
// Entity Framework Core + MySQL
// =====================================================

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(
        connectionString,
        ServerVersion.AutoDetect(connectionString)
    )
);

var app = builder.Build();

// =====================================================
// Configuración del pipeline HTTP
// =====================================================

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

// Archivos estáticos
app.MapStaticAssets();

// =====================================================
// Ruta principal
// =====================================================

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Productos}/{action=Index}/{id?}"
)
.WithStaticAssets();    

app.Run();