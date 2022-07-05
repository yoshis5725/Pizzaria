using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzaria.Models;

namespace Pizzaria.Pages;

public class Pizza : PageModel
{
    public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
    {
        new PizzasModel()
        {
            ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 2, TomatoSauce = true, Cheese = true,
            FinalPrice = 6
        },
        new PizzasModel()
        {
            ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 2, TomatoSauce = true, Cheese = true,
            Pineapple = true, Ham = true, FinalPrice = 9
        },
        new PizzasModel()
        {
            ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 2, TomatoSauce = true, Cheese = true,
            Ham = true, Peperoni = true, Beef = true, FinalPrice = 11
        },
        new PizzasModel()
        {
            ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 2, TomatoSauce = true, Cheese = true,
            Mushroom = true, Peperoni = true, FinalPrice = 6
        },
        new PizzasModel()
        {
            ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 2, TomatoSauce = true, Tuna = true,
            Mushroom = true, FinalPrice = 8
        },
        new PizzasModel()
        {
            ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 2, TomatoSauce = true, Cheese = true,
            Mushroom = true, FinalPrice = 6
        }
    };
    
    public void OnGet()
    {
        
    }
}