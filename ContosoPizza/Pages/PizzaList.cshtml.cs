using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContossoPizza.Pages
{
    public class PizzaListModel : PageModel
    {
        private readonly PizzaService _service;
        public IList<Pizza> PizzaList{get;set;} = default!;

        public PizzaListModel(PizzaService service)
        {
            _service=service;
        }
        public void OnGet()
        {
            PizzaList = _service.GetPizzas();
        }
    }
}
