using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository;
using GroceryFinal.DataAccess.Repository.IRepository;
using GroceryFinal.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GroceryFinal.Controllers
{
    [Authorize(Roles =SD.Role_Admin)]
    public class CustomerDetailsController : Controller
    {
        private readonly IUnitOfWork _customerRepo;
        public CustomerDetailsController(IUnitOfWork db)
        {
            _customerRepo = db;
        }
        public IActionResult Index()
        {
            var objCustomerList = _customerRepo.CustomerDetailsRepository.GetAll().ToList();
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
                _customerRepo.CustomerDetailsRepository.Add(obj);
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

            CustomerDetails? customerDetailsFromDb = _customerRepo.CustomerDetailsRepository.Get(u=>u.CustomerId==id);

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
                _customerRepo.CustomerDetailsRepository.Update(obj);
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

            CustomerDetails? customerDetailsFromDb = _customerRepo.CustomerDetailsRepository.Get(u => u.CustomerId == id);

            if (customerDetailsFromDb == null)
            {
                return NotFound();
            }

            return View(customerDetailsFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            CustomerDetails? obj = _customerRepo.CustomerDetailsRepository.Get(u => u.CustomerId == id);

            if (obj == null)
            {
                return NotFound();
            }
            _customerRepo.CustomerDetailsRepository.Remove(obj);
            _customerRepo.Save();
            TempData["success"] = "Customer Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
