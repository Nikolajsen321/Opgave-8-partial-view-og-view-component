using Microsoft.AspNetCore.Mvc;
using Opgave_8_partial_view_og_view_component.Models;

namespace Opgave_8_partial_view_og_view_component.Components
{
    public class VisEnPersonViewComponent : ViewComponent 
    {
        public IViewComponentResult Invoke(Person p)
        {
            // Modificer personen, f.eks. anonymiser hvis under 18
            if (p.Alder < 18)
            {
                p.Navn = "Anonym";
            }

            // Returner view med personen som model
            return View(p);
        }
    }
}
