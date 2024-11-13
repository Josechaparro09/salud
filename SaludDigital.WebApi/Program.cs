using Datos;
using Logica;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
        options.JsonSerializerOptions.WriteIndented = true;
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configurar CORS
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// Registrar servicios
builder.Services.AddScoped<Conexion>();
builder.Services.AddScoped<UsuarioBLL>();
builder.Services.AddScoped<UsuarioDAL>();
builder.Services.AddScoped<PacienteBLL>();
builder.Services.AddScoped<PacienteDAL>();
builder.Services.AddScoped<EspecialidadBLL>();
builder.Services.AddScoped<EspecialidadDAL>();
builder.Services.AddScoped<DoctorBLL>();
builder.Services.AddScoped<DoctorDAL>();
builder.Services.AddScoped<CitaBLL>();
builder.Services.AddScoped<CitaDAL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

// Important: Enable CORS before routing
app.UseCors();

app.UseHttpsRedirection();
app.UseAuthorization();

// Serve static files
app.UseDefaultFiles();
app.UseStaticFiles();

// Map controllers
app.MapControllers();

app.Run();