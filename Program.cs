var builder = WebApplication.CreateBuilder(args);

// A�adir servicios al contenedor.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuraci�n del pipeline HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
