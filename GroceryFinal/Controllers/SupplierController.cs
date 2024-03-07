using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository;
using GroceryFinal.DataAccess.Repository.IRepository;
using GroceryFinal.Model;
using Microsoft.AspNetCore.Mvc;

namespace GroceryFinal.Controllers
{
    public class SupplierController : Controller
    {
        private readonly IUnitOfWork _supplierRepo;
        public SupplierController(IUnitOfWork db)
        {
            _supplierRepo = db;
        }
        public IActionResult Index()
        {
            var objsupplierList = _supplierRepo.SupplierRepository.GetAll().ToList();
            return View(objsupplierList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Supplier obj)
        {
            if (ModelState.IsValid)
            {
                _supplierRepo.SupplierRepository.Add(obj);
                _supplierRepo.Save();
                TempData["success"] = "Supplier Created Successfully!";

            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            Supplier? SupplierFromDb = _supplierRepo.SupplierRepository.Get(u => u.SupplierId == id);

            if (SupplierFromDb == null)
            {
                return NotFound();
            }

            return View(SupplierFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Supplier obj)
        {
            if (ModelState.IsValid)
            {
                _supplierRepo.SupplierRepository.Update(obj);
                _supplierRepo.Save();
                TempData["success"] = "Supplier Details Edited Successfully!";
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

            Supplier? SupplierFromDb = _supplierRepo.SupplierRepository.Get(u => u.SupplierId == id);

            if (SupplierFromDb == null)
            {
                return NotFound();
            }

            return View(SupplierFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Supplier? obj = _supplierRepo.SupplierRepository.Get(u => u.SupplierId == id);

            if (obj == null)
            {
                return NotFound();
            }
            _supplierRepo.SupplierRepository.Remove(obj);
            _supplierRepo.Save();
            TempData["success"] = "Supplier Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
