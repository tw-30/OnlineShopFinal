﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    public class ProductController : Controller
    {
        private ShopContext context;
        public ProductController(ShopContext ctx)
        {
            context = ctx;
        }
        public IActionResult Index()
        {
            return RedirectToAction("List", "Product");
        }
        [Route("[controller]s/{id?}")]
        public IActionResult List(string id = "All")
        {
            var categories = context.Categories
                .OrderBy(p => p.CategoryID).ToList();
            List<Product> products;
            if (id == "All")
            {
                products = context.Products
                    .OrderBy(p => p.ProductID).ToList();
            }
            else if (id == "Workstations")
            {
                products = context.Products
                    .Where(p => p.Category.Name == "Laptops" || p.Category.Name == "Computers")
                    .OrderBy(p => p.ProductID).ToList();
            }
            else
            {
                products = context.Products
                    .Where(p => p.Category.Name == id)
                    .OrderBy(p => p.ProductID).ToList();
            }
            ViewBag.Categories = categories;
            ViewBag.SelectedCategoryName = id;
            if (id == "Workstations")
            {
                ViewBag.SelectedCategoryName = "Workstations";
            }
            return View(products);
        }
        public IActionResult Details(int id)
        {
            var categories = context.Categories
                .OrderBy(c => c.CategoryID).ToList();

            Product product = context.Products.Find(id);

            string imageFilename = product.Code + "_m.png";

            // use ViewBag to pass data to view
            ViewBag.Categories = categories;
            ViewBag.ImageFilename = imageFilename;

            // bind product to view
            return View(product);
        }
    }
}