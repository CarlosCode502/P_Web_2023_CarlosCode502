using Portafolio_Web_2023.Services;//Se importo automátiamente

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//V#57 Inyección de dependencias 
builder.Services.AddTransient<IRepositorioProyecto, RepositorioProyecto>();

//V#66 ENVIANDO EMAILS DESDE LA APP
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

//V#43 Introducción al ruteo
//Existen dos formas de hacer ruteo:
//Ruteo por atributo
//Ruteo convencional
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//Ruteo convencional
//Si no se especifica la ruta se muestra por defecto esta url(id opcional)
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=PortafolioW}/{action=Index}/{id?}");

app.Run();
