using Microsoft.AspNetCore.Mvc;
using OrderManagementApp.Models;

public class OrdersController : Controller
{
    
    public IActionResult Index()
    {
        
        return View();  
    }

    
    public IActionResult Create()
    {
        return View();  
    }

    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Order order)
    {
        if (ModelState.IsValid)
        {
           
            return RedirectToAction(nameof(Index));  
        }
        return View(order);  
    }

    
    public IActionResult Edit(int id)
    {
        
        return View();  
    }

    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Order order)
    {
        if (id != order.Id)
        {
            return BadRequest();
        }

        if (ModelState.IsValid)
        {
            
            return RedirectToAction(nameof(Index));  
        }
        return View(order);  
    }
}
