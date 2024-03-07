using GroceryApp.DataAccess.Data;
using GroceryApp.Models;
using GroceryFinal.DataAccess.Repository;
using GroceryFinal.DataAccess.Repository.IRepository;
using GroceryFinal.Model;
using Microsoft.AspNetCore.Mvc;

namespace GroceryFinal.Controllers
{
    public class StateController : Controller
    {
        private readonly IUnitOfWork _StateRepo;
        public StateController(IUnitOfWork db)
        {
            _StateRepo = db;
        }
        public IActionResult Index()
        {
            var objStateList = _StateRepo.StateRepository.GetAll().ToList();
            return View(objStateList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(State obj)
        {
            if (ModelState.IsValid)
            {
                _StateRepo.StateRepository.Add(obj);
                _StateRepo.Save();
                TempData["success"] = "State Created Successfully!";

            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            State? StateFromDb = _StateRepo.StateRepository.Get(u => u.StateId == id);

            if (StateFromDb == null)
            {
                return NotFound();
            }

            return View(StateFromDb);
        }

        [HttpPost]
        public IActionResult Edit(State obj)
        {
            if (ModelState.IsValid)
            {
                _StateRepo.StateRepository.Update(obj);
                _StateRepo.Save();
                TempData["success"] = "State Details Edited Successfully!";
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

            State? StateFromDb = _StateRepo.StateRepository.Get(u => u.StateId == id);

            if (StateFromDb == null)
            {
                return NotFound();
            }

            return View(StateFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            State? obj = _StateRepo.StateRepository.Get(u => u.StateId == id);

            if (obj == null)
            {
                return NotFound();
            }
            _StateRepo.StateRepository.Remove(obj);
            _StateRepo.Save();
            TempData["success"] = "State Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}
