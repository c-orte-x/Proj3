using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project3.Models;
using Project3.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project3.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PeopleService peopleService;

        public PeopleController(PeopleService peopleService)
        {
            this.peopleService = peopleService;
        }

        
        public ActionResult Index()
        {
            return View(peopleService.Get());
        }

        
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var people = peopleService.Get(id);
            if (people == null)
            {
                return NotFound();
            }
            return View(people);
        }

        
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(People people)
        {
            if (ModelState.IsValid)
            {
                peopleService.Create(people);
                return RedirectToAction(nameof(Index));
            }
            return View(people);
        }

        
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var people = peopleService.Get(id);
            if (people == null)
            {
                return NotFound();
            }
            return View(people);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, People people)
        {
            if (id != people.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                peopleService.Update(id, people);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(people);
            }
        }

        
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var people = peopleService.Get(id);
            if (people == null)
            {
                return NotFound();
            }
            return View(people);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                var people = peopleService.Get(id);

                if (people == null)
                {
                    return NotFound();
                }

                peopleService.Remove(people.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
