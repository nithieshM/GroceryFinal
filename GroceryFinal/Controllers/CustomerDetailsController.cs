using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository;
using GroceryFinal.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace GroceryFinal.Controllers
{
    public class CustomerDetailsController : Controller
    {
        private readonly ICustomerDetailsRepository _customerRepo;
        public CustomerDetailsController(ICustomerDetailsRepository db)
        {
            _customerRepo = db;
        }
        public IActionResult Index()
        {
            var objCustomerList = _customerRepo.GetAll().ToList();
            return View(objCustomerList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerDetails obj)
        {
            if(ModelState.IsValid)
            {
                _customerRepo.Add(obj);
                _customerRepo.Save();
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

            CustomerDetails? customerDetailsFromDb = _customerRepo.Get(u=>u.CustomerId==id);

            if(customerDetailsFromDb == null)
            {
                return NotFound();
            }

            return View(customerDetailsFromDb);
        }

        [HttpPost]
        public IActionResult Edit(CustomerDetails obj)
        {
            if (ModelState.IsValid)
            {
                _customerRepo.Update(obj);
                _customerRepo.Save();
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

            CustomerDetails? customerDetailsFromDb = _customerRepo.Get(u => u.CustomerId == id);

            if (customerDetailsFromDb == null)
            {
                return NotFound();
            }

            return View(customerDetailsFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            CustomerDetails? obj = _customerRepo.Get(u => u.CustomerId == id);

            if (obj == null)
            {
                return NotFound();
            }
            _customerRepo.Remove(obj);
            _customerRepo.Save();
            TempData["success"] = "Customer Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
