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
    public class ReturnsController : Controller
    {
        private readonly ReturnsService returnsService;

        public ReturnsController(ReturnsService returnsService)
        {
            this.returnsService = returnsService;
        }

    
        public ActionResult Index()
        {
            return View(returnsService.Get());
        }

      
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returns = returnsService.Get(id);
            if (returns == null)
            {
                return NotFound();
            }
            return View(returns);
        }

        
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Returns returns)
        {
            if (ModelState.IsValid)
            {
                returnsService.Create(returns);
                return RedirectToAction(nameof(Index));
            }
            return View(returns);
        }

      
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returns = returnsService.Get(id);
            if (returns == null)
            {
                return NotFound();
            }
            return View(returns);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Returns returns)
        {
            if (id != returns.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                returnsService.Update(id, returns);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(returns);
            }
        }

      
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var returns = returnsService.Get(id);
            if (returns == null)
            {
                return NotFound();
            }
            return View(returns);
        }

       
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                var returns = returnsService.Get(id);

                if (returns == null)
                {
                    return NotFound();
                }

                returnsService.Remove(returns.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
