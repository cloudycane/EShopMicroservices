var builder = WebApplication.CreateBuilder(args);

// A�adir servicios al contenedor

var app = builder.Build();

// Configuraci�n del HTTP pipeline

app.Run();
