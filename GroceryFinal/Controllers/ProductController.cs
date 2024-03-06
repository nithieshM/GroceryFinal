using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository;
using GroceryFinal.DataAccess.Repository.IRepository;
using GroceryFinal.Model;
using Microsoft.AspNetCore.Mvc;

namespace GroceryFinal.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _productRepo;
        public ProductController(IUnitOfWork db)
        {
            _productRepo = db;
        }
        public IActionResult Index()
        {
            var objCustomerList = _productRepo.ProductRepository.GetAll().ToList();
            return View(objCustomerList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            if(ModelState.IsValid)
            {
                _productRepo.ProductRepository.Add(obj);
                _productRepo.Save();
                TempData["success"] = "Customer Created Successfully!";

            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            Product? ProductFromDb = _productRepo.ProductRepository.Get(u=>u.ProductId==id);

            if(ProductFromDb == null)
            {
                return NotFound();
            }

            return View(ProductFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Product obj)
        {
            if (ModelState.IsValid)
            {
                _productRepo.ProductRepository.Update(obj);
                _productRepo.Save();
                TempData["success"] = "Customer Details Edited Successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Product? ProductFromDb = _productRepo.ProductRepository.Get(u => u.ProductId == id);

            if (ProductFromDb == null)
            {
                return NotFound();
            }

            return View(ProductFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Product? obj = _productRepo.ProductRepository.Get(u => u.ProductId == id);

            if (obj == null)
            {
                return NotFound();
            }
            _productRepo.ProductRepository.Remove(obj);
            _productRepo.Save();
            TempData["success"] = "Customer Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
