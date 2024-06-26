using Microsoft.EntityFrameworkCore;
using Produtos_2024.Data;
using Produtos_2024.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<BancoContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

builder.Services.AddScoped<IProdutoRepositorio, ProdutoRepositorio>();

builder.Services.AddRazorPages().AddMvcOptions(options => 
{ 
    options.MaxModelValidationErrors = 50; 
    options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(_ => "Este campo � obrigat�rio!"); 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
