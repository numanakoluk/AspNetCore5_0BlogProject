using BusinessLayer.Concrete;
using DataAcessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository()); //Ef'yi burada kullanıyorum
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
