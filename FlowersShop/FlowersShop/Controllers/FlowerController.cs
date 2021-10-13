using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlowersShop.Models;
using FlowersShop.Services;

namespace FlowersShop.Controllers
{
    public class FlowerController : Controller
    {
        private readonly IFlowerService _flowerService;

        public FlowerController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }

        public IActionResult Index()
        {
            return View(_flowerService.Get());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Flower flower)
        {
            _flowerService.Create(flower);
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Flower flower)
        {
            _flowerService.Edit(flower);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id)
        {
            _flowerService.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Get(Guid id)
        {
            return View(_flowerService.Get(id));
        }
    }
}
