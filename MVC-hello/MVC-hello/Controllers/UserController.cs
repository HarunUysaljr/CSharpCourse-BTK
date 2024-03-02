using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    public IActionResult SignUp()
    {
        return View("SignUp");
    }

    public IActionResult Profile()
    {
        return View("Profile");
    }
}