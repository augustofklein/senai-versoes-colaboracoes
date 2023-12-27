using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Augusto Fernando Klein", "999.999.999-99", "augusto.klein@gmail.com", "Augusto");
        Cliente cliente2 = new Cliente(02, "Fulano", "888.888.888-88", "fulano@gmail.com", "Fulano");
        Cliente cliente3 = new Cliente(03, "Ciclano", "777.777.777-77", "ciclano@gmail.com", "Ciclano");
        Cliente cliente4 = new Cliente(04, "Fulamix", "666.666.666-66", "fulamix@gmail.com", "Fulamix");
        Cliente cliente5 = new Cliente(05, "Carlos", "555.555.555-55", "carlos@gmail.com", "Carlos");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "Cabos e malhas", "99.999.999/0001-09", "cabos@gmail.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Agromais", "88.888.888/0001-08", "agromaix@gmail.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Multimarcas", "77.777.777/0001-07", "multimarcas@gmail.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Sérgio Parafusos", "66.666.666/0001-06", "parafusos@gmail.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Eletrica Top", "55.555.555/0001-05", "eletricatop@gmail.com");
        
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
