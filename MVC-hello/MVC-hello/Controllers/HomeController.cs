using Microsoft.AspNetCore.Mvc;

namespace MVC_hello.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
        //Action adı ile Dönülen view adı aynıysa parametre olarak vermeye gerek yok.
    }

    public string Selam()
    {
        return "Buraya Bakarlar!";
    }

    //Controoler içerisindeki metot - action
}
