using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository;
using GroceryFinal.DataAccess.Repository.IRepository;
using GroceryFinal.Model;
using GroceryFinal.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GroceryFinal.Controllers
{
    [Authorize(Roles = SD.Role_Admin)]

    public class UOMController : Controller
    {
        private readonly IUnitOfWork _UOMRepo;
        public UOMController(IUnitOfWork db)
        {
            _UOMRepo = db;
        }
        public IActionResult Index()
        {
            var objUOMList = _UOMRepo.UOMRepository.GetAll().ToList();
            return View(objUOMList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UOM obj)
        {
            if (ModelState.IsValid)
            {
                _UOMRepo.UOMRepository.Add(obj);
                _UOMRepo.Save();
                TempData["success"] = "UOM Created Successfully!";

            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            UOM? UOMFromDb = _UOMRepo.UOMRepository.Get(u => u.UOMId == id);

            if (UOMFromDb == null)
            {
                return NotFound();
            }

            return View(UOMFromDb);
        }

        [HttpPost]
        public IActionResult Edit(UOM obj)
        {
            if (ModelState.IsValid)
            {
                _UOMRepo.UOMRepository.Update(obj);
                _UOMRepo.Save();
                TempData["success"] = "UOM Details Edited Successfully!";
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

            UOM? UOMFromDb = _UOMRepo.UOMRepository.Get(u => u.UOMId == id);

            if (UOMFromDb == null)
            {
                return NotFound();
            }

            return View(UOMFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            UOM? obj = _UOMRepo.UOMRepository.Get(u => u.UOMId == id);

            if (obj == null)
            {
                return NotFound();
            }
            _UOMRepo.UOMRepository.Remove(obj);
            _UOMRepo.Save();
            TempData["success"] = "UOM Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
