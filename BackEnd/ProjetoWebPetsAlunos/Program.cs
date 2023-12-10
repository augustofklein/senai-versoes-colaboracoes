namespace ProjetoWebPetsAlunos;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();

        app.MapGet("/", () => "Projeto Web - LH Pets versão 1");

        app.MapGet("/index.html", (HttpContext contexto) => {
            contexto.Response.Redirect("index.html", false);
        });

        app.Run();
    }
}
