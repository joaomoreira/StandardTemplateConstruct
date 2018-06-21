using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Serilog;
using StandardTemplateConstruct.Models;
using StandardTemplateConstruct.Services;
using StandardTemplateConstruct.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardTemplateConstruct.Controllers
{
    public class HomeController : Controller
    {
        private IArmyListService _service;

        public HomeController(IArmyListService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ArmyList armyList)
        {
            if (ModelState.IsValid)
            {
                ArmyList newList = new ArmyList()
                {
                    Name = armyList.Name,
                };

                newList = _service.Add(armyList);
                return RedirectToAction(nameof(Details), new { id = newList.Id });
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _service.Get(id);

            if (model == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _service.Get(id);

            if (model == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ArmyList armyList)
        {
            if(ModelState.IsValid)
            {
                _service.Update(armyList);

                return RedirectToAction("Details", "Home", new { id = armyList.Id });
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Index()
        {
            var model = new IndexViewModel()
            {
                ArmyLists = _service.GetAll()
            };
            return View(model);
        }
    }
}
