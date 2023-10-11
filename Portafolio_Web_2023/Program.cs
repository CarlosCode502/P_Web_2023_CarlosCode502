using Portafolio_Web_2023.Services;//Se importo automátiamente

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//V#57 Inyección de dependencias 
//AQUI ABAJO VOY A PODER DECLARAR O CONFIGURAR LAS INYECCIONES DE DEPENDENCIAS
//De esta manera es posible inyectar la clase RepositorioProyectos
//builder.Services.AddTransient<RepositorioProyectos>();

//V#58 Inyección de dependencias con Interfaces
//Cuando HomeController pida una instancia de IRepositorioProyectos se le envie RepositorioProyecto es decir nuestro repositorio local
//En caso de que en el futuro se implemente otro repositorio desde una bd o similar solo de deba cambiar la ruta a la que apunta la interfaz
builder.Services.AddTransient<IRepositorioProyecto, RepositorioProyecto>();

//V#66 ENVIANDO EMAILS DESDE LA APP
//Configuramos el servicio en la clase para inyecciones de dependencias
//Como este servicio no necesita compartir datos usamos AddTransient(cambia el Guid)
builder.Services.AddTransient<IServicioEmailSendGrid, ServicioEmailSendGrid>();

//builder.Services.AddTransient<IRepositorioArchivos, RepositorioArchivos>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/PortafolioW/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

//V#43 Introducción al ruteo
//En este apartado tambien es posible configurar el ruto o las reglas de ruteo
//Las reglas de ruteo indican la accion a realizar al momento de mostrar o ejecutar
//nuestra app cuya acción es mostrarse por defecto 

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
