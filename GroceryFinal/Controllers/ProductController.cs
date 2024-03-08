using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository;
using GroceryFinal.DataAccess.Repository.IRepository;
using GroceryFinal.Model;
using GroceryFinal.Model.ViewModel;
using GroceryFinal.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GroceryFinal.Controllers
{
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _productRepo;
        public ProductController(IUnitOfWork db)
        {
            _productRepo = db;
        }
        public IActionResult Index()
        {
            var objCustomerList = _productRepo.ProductRepository.GetAll(includeProperties: new string[] { "Supplier", "UOM" }).ToList();
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
                UOMList = _productRepo.UOMRepository.GetAll().Select(u => new SelectListItem 
                {
                    Text = $"{u.UOMId} - {u.UOMName}",
                    Value = u.UOMId.ToString()
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
                TempData["success"] = "Product Created Successfully!";
                if (obj.Product.ProductId == 0)
                {
                    _productRepo.ProductRepository.Add(obj.Product);
                    TempData["success"] = "Product Created Successfully!";
                }
                else
                {
                    _productRepo.ProductRepository.Update(obj.Product);
                    TempData["success"] = "Product Edited Sucessfully";
                }
                
                _productRepo.Save();
                
                return RedirectToAction("Index");
            }
            else
            {
                obj.SupplierList = _productRepo.SupplierRepository.GetAll().Select(u => new SelectListItem
                {
                    Text = $"{u.SupplierId} - {u.SupplierName}",
                    Value = u.SupplierId.ToString()
                });
                obj.UOMList = _productRepo.UOMRepository.GetAll().Select(u => new SelectListItem
                {
                    Text = $"{u.UOMId} - {u.UOMName}",
                    Value = u.UOMId.ToString()
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
            TempData["success"] = "Product Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
