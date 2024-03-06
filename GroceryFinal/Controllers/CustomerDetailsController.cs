using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GroceryFinal.Controllers
{
    public class CustomerDetailsController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerDetailsController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objCustomerList = _db.CustomerDetailsTable.ToList();
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
                _db.CustomerDetailsTable.Add(obj);
                _db.SaveChanges();
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

            CustomerDetails? customerDetailsFromDb = _db.CustomerDetailsTable.Find(id);

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
                _db.CustomerDetailsTable.Update(obj);
                _db.SaveChanges();
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

            CustomerDetails? customerDetailsFromDb = _db.CustomerDetailsTable.Find(id);

            if (customerDetailsFromDb == null)
            {
                return NotFound();
            }

            return View(customerDetailsFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            CustomerDetails? obj = _db.CustomerDetailsTable.Find(id);

            if(obj == null)
            {
                return NotFound();
            }
            _db.Remove(obj);
            _db.SaveChanges();
            TempData["success"] = "Customer Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
