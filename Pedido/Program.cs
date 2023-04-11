using Microsoft.EntityFrameworkCore;
using Pedido;
using Pedido.Repositorio.Contexto;
using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);
var idi = new IDI();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Config Banco
builder.Services.AddDbContext<ContextoBanco>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

// Injeção de idependecia
idi.IdiAplic(builder);
idi.IdiRepositorio(builder);

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.Run();

//Data Source = DESKTOP - THCVMG5; Initial Catalog = DB_Pedido_Restaurante; Persist Security Info=True; User ID = sa; Password = Mygame2002; TrustServerCertificate = true;
