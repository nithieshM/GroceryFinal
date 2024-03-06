using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository;
using GroceryFinal.DataAccess.Repository.IRepository;
using GroceryFinal.Model;
using GroceryFinal.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var objCustomerList = _productRepo.ProductRepository.GetAll(includeProperties:"Supplier").ToList();
            return View(objCustomerList);
        }

        public IActionResult Upsert(int? id)
        {

            ProductVM productVM = new()
            {
                SupplierList = _productRepo.SupplierRepository.GetAll().Select(u => new SelectListItem
                {
                    Text = $"{u.SupplierId} - {u.SupplierName}",
                    Value = u.SupplierId.ToString()
                }),
                Product = new Product()
            };
            if(id == null || id == 0)
            {//create
                return View(productVM);
            }
            else
            {//update
                productVM.Product = _productRepo.ProductRepository.Get(u => u.ProductId == id);
                return View(productVM);
            }
        }

        [HttpPost]
        public IActionResult Upsert(ProductVM obj)
        {
            if(ModelState.IsValid)
            {
                if(obj.Product.ProductId == 0)
                {
                    _productRepo.ProductRepository.Add(obj.Product);
                }
                else
                {
                    _productRepo.ProductRepository.Update(obj.Product);
                }
                
                _productRepo.Save();
                TempData["success"] = "Product Created Successfully!";
                return RedirectToAction("Index");
            }
            else
            {
                obj.SupplierList = _productRepo.SupplierRepository.GetAll().Select(u => new SelectListItem
                {
                    Text = $"{u.SupplierId} - {u.SupplierName}",
                    Value = u.SupplierId.ToString()
                });
                 
                return View(obj);
            }   

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
