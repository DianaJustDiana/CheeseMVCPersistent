using System.Collections.Generic;
using System.Linq;
using CheeseMVC.Data;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CheeseMVC.Controllers
{
    public class MenuController : Controller
    {
        // GET
        public IActionResult Index()
        {
            List<Menu> menus = context.Menus.ToList();

            ViewBag.title = "All the menus";
            
            return View(menus);
        }
        //get
        public IActionResult Add()
        {
            AddMenuViewModel addMenuViewModel = new AddMenuViewModel(context.Menus.ToList());
            return View(addMenuViewModel);
        }
       
        private readonly CheeseDbContext context;

        public MenuController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }
    }
}