namespace ProjetoWebPetsAlunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Hello World!");

        app.UseStaticFiles();
        app.MapGet("/index", (HttpContext contexto) => {
            contexto.Response.Redirect("index.html", false);
        });

        app.Run();
    }
}
