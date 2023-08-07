var builder = WebApplication.CreateBuilder(args);//Kestrel Server
builder.Services.AddControllersWithViews();//MVC
var app = builder.Build();//Uygulama Ayaða kalktý
if (!app.Environment.IsDevelopment()) app.UseStatusCodePagesWithRedirects("/hata/{0}");
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(name: "default", pattern:"{controller=home}/{action=index}/{id?}");
app.Run();
