using Microsoft.AspNetCore.Mvc;
using SC.Models;
using SC.Repositories.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Controllers
{
    public class MhsController : Controller
    {
        MhsRepository MhsRepository;

        public MhsController(MhsRepository MhsRepository)
        {
            this.MhsRepository = MhsRepository;
        }

        // GET ALL
        // GET
        public IActionResult Index()
        {

            var data = MhsRepository.Get();
            return View(data);

        }

        // GET BY ID
        //GET
        public IActionResult Details(int id)
        {
            var data = MhsRepository.Get(id);
            return View(data);
        }

        // CREATE 
        // GET
        public IActionResult Create()
        {
            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Mhs mhs)
        {
            if (ModelState.IsValid)
            {

                var result = MhsRepository.Post(mhs);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }

        // UPDATE
        // GET
        [HttpGet]
        public ActionResult Edit()
        {

            return View();
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Mhs mhs)
        {
            if (ModelState.IsValid)
            {
                var result = MhsRepository.Put(id, mhs);
                if (result > 0)
                    return RedirectToAction("Index");
            }
            return View();
        }


        // DELETE
        // GET
        public ActionResult Remove(int id)
        {
            var data = MhsRepository.Get(id);
            return View(data);
        }
        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Remove(Mhs mhs)
        {
            var result = MhsRepository.Remove(mhs);
            if (result > 0)
                return RedirectToAction("Index");
            return View();
        }
    }
}
