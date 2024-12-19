using Microsoft.AspNetCore.Mvc;
using OrderManagementApp.Models;

public class ProductsController : Controller
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
    public IActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            
            return RedirectToAction(nameof(Index));   
        }
        return View(product); 
    }

    
    public IActionResult Edit(int id)
    {
        
        return View(); 
    }

    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Product product)
    {
        if (id != product.Id)
        {
            return BadRequest();
        }

        if (ModelState.IsValid)
        {
         
            return RedirectToAction(nameof(Index)); 
        }
        return View(product); 
    }
}

