using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MybookWeb.Interface;
using MybookWeb.Models;
using MybookWeb.Entities;
using Publisher = MybookWeb.Entities.Publisher;
using MybookWeb.Enums;

namespace MybookWeb.Controllers
{
    public class PublisherController : BaseController
    {
        private IPublisher _pub;
        public PublisherController(IPublisher pub)
        {
            _pub = pub;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _pub.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Publisher p)
        {
            var createPub = await _pub.AddAsync(p);

            if (createPub)
            {
                Alert("Publisher Created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {   
                Alert("Publisher not Created!", NotificationType.error);
            }
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        
        public async Task<IActionResult> Delete(int id)
        {
            var deletePub = await _pub.Delete(id);
            if (deletePub)
            {
                Alert("Publisher Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                 Alert("Publisher not Deleted!", NotificationType.error);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Publisher p)
        {
            var editPub = await _pub.Update(p);
            if (editPub && ModelState.IsValid)
            {
                Alert("Publisher Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Publisher not Edited!", NotificationType.error);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editPub = await _pub.GetById(id);
            if (editPub == null)
            {
                return RedirectToAction("Index");
            }
            return View(editPub);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
