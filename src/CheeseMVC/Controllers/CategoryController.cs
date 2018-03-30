using System.Collections.Generic;
using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class CategoryController : Controller
    {
        // GET
        public IActionResult Index()
        {
            List<CheeseCategory> categories = context.CheeseCategories.ToList();

            ViewBag.title = "All the cheese categories";

            
            return View(categories);
           
        }

        public IActionResult Add()
        {
            AddCategoryViewModel addCategoryViewModel = new AddCategoryViewModel();
            return View(addCategoryViewModel);
        }
        
        

        private readonly CheeseDbContext context;

        public CategoryController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }
    }
}
