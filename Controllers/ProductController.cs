using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MattNyce.Data;
using MattNyce.Models;

namespace MattNyce.Controllers
{
    public class ProductController : Controller
    {
        private ProductContext context { get; set; }
        public ProductController(ProductContext ctx)
        {
            context = ctx;
        }

        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Product());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var product = context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.Id == 0)
                {
                    context.Products.Add(product);
                }
                else
                {
                    context.Products.Update(product);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                ViewBag.Action = (product.Id == 0) ? "Add" : "Edit";
                return View(product);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.Action = "Delete";
            var product = context.Products.Find(id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            ViewBag.Action = "Delete";
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Product");
        }
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }
    }
}
