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
    public class OrdersController : Controller
    {
        private readonly OrdersService ordersService;

        public OrdersController(OrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        
        public ActionResult Index()
        {
            return View(ordersService.Get());
        }

        
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = ordersService.Get(id);
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }

        
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Orders orders)
        {
            if (ModelState.IsValid)
            {
                ordersService.Create(orders);
                return RedirectToAction(nameof(Index));
            }
            return View(orders);
        }

        
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = ordersService.Get(id);
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Orders orders)
        {
            if (id != orders.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                ordersService.Update(id, orders);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(orders);
            }
        }

        
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orders = ordersService.Get(id);
            if (orders == null)
            {
                return NotFound();
            }
            return View(orders);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            try
            {
                var orders = ordersService.Get(id);

                if (orders == null)
                {
                    return NotFound();
                }

                ordersService.Remove(orders.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
