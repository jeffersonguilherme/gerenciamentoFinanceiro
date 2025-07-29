using Microsoft.AspNetCore.Mvc;


namespace GerenciamentoFinanceiro.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
