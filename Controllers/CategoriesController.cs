using EtkinlikProjesi.Data;
using EtkinlikProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EtkinlikProjesi.Controllers
{
    public class CategoriesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Categories> categories = _context.Categories.ToList();
            return View(categories);

        }
    }
}
