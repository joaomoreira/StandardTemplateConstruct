using Microsoft.AspNetCore.Mvc;
using StandardTemplateConstruct.Models;
using StandardTemplateConstruct.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandardTemplateConstruct.Controllers
{
    public class ArmyListController : Controller
    {
        private IArmyListService _service;

        public ArmyListController(IArmyListService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
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

       
    }
}
