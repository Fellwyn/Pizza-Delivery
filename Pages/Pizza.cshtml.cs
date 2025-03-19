using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Delivery.Models;

namespace Delivery.Pages
{
    public class PizzaModel : PageModel
    {

        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle = "Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=4},

            new PizzasModel(){ImageTitle = "Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice=5},

            new PizzasModel(){ImageTitle = "Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                Pineapple= true,
                FinalPrice=8},

        new PizzasModel(){ImageTitle = "Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Peperoni=true,
                Mushroom= true,
                FinalPrice=6}



            
        };

        public void OnGet()
        {
        }
    }
}
