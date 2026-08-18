var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hola Ricardo, ahora con CI/CD funcionando!");

app.MapGet("/status", () => new
{
    status = "ok",
    mensaje = "Contenedor funcionando correctamente",
    fecha = DateTime.UtcNow
});

app.Run("http://0.0.0.0:8080");
