namespace DemoMVC.Controllers
{
    using DemoMVC.Data;
    using DemoMVC.Models.Entities;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.EntityFrameworkCore;

    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _Context;
        public CustomerController(ApplicationDbContext context)
        {
            _Context = context;
        }
        //Action Index
        public async Task<IActionResult> Index()
        {
            return View(await _Context.Customer.ToListAsync());
        } 
        //Action create: GET, POST
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Customer cus)
        {
            if(ModelState.IsValid)
            {
                _Context.Add(cus);
                await _Context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cus);
        }
        // GET: Student/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var cus = await _Context.Customer;
        }
    }
}