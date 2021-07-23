using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_CRUD_Project.DAL;
using MVC_CRUD_Project.Models;

namespace MVC_CRUD_Project.Controllers
{
    public class ProductController : Controller
    {

        ProductRepository proRepo;

        public ProductController(ProductContext _dbcontext)
        {
            proRepo = new ProductRepository(_dbcontext);
        }
        public IActionResult ProductDetails()
        {
            var test = proRepo.GetProducts().ToList();

            var lstProducts = proRepo.GetProducts().Select(e => new ProductViewModel
            {
                ProductId = e.ProductId,
                ProductName = e.ProductName,
                Quantity = e.Quantity,
                Color = e.Color,
                Price=e.Price
              
            
            }).ToList();

            return View(lstProducts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ProductViewModel pro = new ProductViewModel();
            return View(pro);
        }
        [HttpPost]
        public IActionResult Create(ProductViewModel pro)
        {
            if(ModelState.IsValid)
            {
                Product proEntity = new Product()
                {
                    ProductId = pro.ProductId,
                    ProductName = pro.ProductName,
                    Quantity = pro.Quantity,
                    Color = pro.Color,
                    Price = pro.Price
                };
                proRepo.CreateProduct(proEntity);
            }
            return RedirectToAction("ProductDetails");
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            ProductViewModel selectedProduct = proRepo.GetProducts().Where(i => i.ProductId == id).Select(e => new ProductViewModel
            {
                ProductId=e.ProductId,
                ProductName=e.ProductName,
                Quantity=e.Quantity,
                Color=e.Color,
                Price=e.Price

            }).FirstOrDefault();

            return View(selectedProduct);
        }

        [HttpPost]

        public IActionResult Edit(ProductViewModel pro)
        {
            if(ModelState.IsValid)
            {
                Product proEntity = new Product()
                {
                    ProductId = pro.ProductId,
                    ProductName = pro.ProductName,
                    Quantity = pro.Quantity,
                    Color = pro.Color,
                    Price = pro.Price
                };
                proRepo.EditProduct(proEntity);
            }
            return RedirectToAction("ProductDetails");
        }

        [HttpGet]

        public IActionResult Details(int id)
        {
            ProductViewModel selectedProduct = proRepo.GetProducts().Where(i => i.ProductId == id).Select(e => new ProductViewModel
            {
                ProductId = e.ProductId,
                ProductName = e.ProductName,
                Quantity = e.Quantity,
                Color = e.Color,
                Price = e.Price

            }).FirstOrDefault();

            return View(selectedProduct);
        }

        [HttpGet]

        public IActionResult Delete(int id)
        {
            ProductViewModel selectedProduct = proRepo.GetProducts().Where(i => i.ProductId == id).Select(e => new ProductViewModel
            {
                ProductId = e.ProductId,
                ProductName = e.ProductName,
                Quantity = e.Quantity,
                Color = e.Color,
                Price = e.Price

            }).FirstOrDefault();

            return View(selectedProduct);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public IActionResult DeleteConfirmed(int id)
        {
            proRepo.DeleteProduct(id);

            return RedirectToAction("ProductDetails");
        }
    }
}