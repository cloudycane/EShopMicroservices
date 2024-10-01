var builder = WebApplication.CreateBuilder(args);

// Añadir servicios al contenedor

var app = builder.Build();

// Configuración del HTTP pipeline

app.Run();
