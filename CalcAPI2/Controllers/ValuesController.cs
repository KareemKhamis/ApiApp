using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
namespace CalcAPI2.Controllers
{

    public class ValuesController_main : Controller

    {
        // GET: ValuesController main test
        [HttpGet("/hello")]
        public async Task <string> Hello()
        {
            var client = new HttpClient();
            var result = await client.GetStringAsync("https://localhost:44392/average?nums=4&nums=12&nums=2&nums=15&nums=29");
            return result;
        }

        // GET: ValuesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ValuesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ValuesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ValuesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ValuesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ValuesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ValuesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
