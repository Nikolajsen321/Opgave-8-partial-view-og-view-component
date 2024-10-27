using Microsoft.AspNetCore.Mvc;
using Opgave_8_partial_view_og_view_component.Models;

namespace Opgave_8_partial_view_og_view_component.Controllers
{
    public class HomeController : Controller
    {
        //Action metoder
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VisAlle()
        {
            var allePersoner = AllePersoner();


            return View(allePersoner);
        }
        public IActionResult VisEn()
        {
            Person person = AllePersoner().FirstOrDefault();

            return View(person);
        }


        //interne Metoder

        public List<Person> AllePersoner()
        {
            List<Person> persons = new List<Person>
            { new Person(), new Person("Jens",30) };
            return persons;
        }
        
    }
}
