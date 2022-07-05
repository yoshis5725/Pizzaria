using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Data;
using Pizzaria.Models;

namespace Pizzaria.Pages;

public class Orders : PageModel
{
    public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();

    private readonly ApplicationDbContext _context;
    
    
    public Orders(ApplicationDbContext context)
    {
        _context = context;
    }
    
    
    public void OnGet()
    {
        PizzaOrders = _context.PizzaOrders.ToList();
    }
}