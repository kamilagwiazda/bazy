using Microsoft.AspNetCore.Mvc;
using OrderManagementApp.Models;

public class AccountController : Controller
{

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {

            return RedirectToAction("Index", "Home");
        }
        return View(model);
    }


    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {

        }
        return View(model);
    }


    [HttpPost]
    public IActionResult Logout()
    {

        return RedirectToAction("Index", "Home");
    }
}





