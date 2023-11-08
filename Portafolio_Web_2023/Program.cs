using Portafolio_Web_2023.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddTransient<IRepositorioProyecto, RepositorioProyecto>();

builder.Services.AddTransient<IServicioEmailSendGrid, ServicioEmailSendGrid>();

//builder.Services.AddTransient<IRepositorioArchivos, RepositorioArchivos>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment() && !app.Environment.IsProduction())
{
	app.UseExceptionHandler("/PortafolioW/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=PortafolioW}/{action=Index}/{id?}");

app.Run();
