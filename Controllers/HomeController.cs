using Microsoft.AspNetCore.Mvc;

namespace gerenciamentoFinanceiro.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
