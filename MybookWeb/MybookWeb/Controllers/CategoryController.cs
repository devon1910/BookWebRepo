﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MybookWeb.Entities;
using MybookWeb.Enums;
using MybookWeb.Interface;
using MybookWeb.Models;

namespace MybookWeb.Controllers
{
    public class CategoryController : BaseController
    {
        private ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await _category.GetAll();
            if (model != null)
            {
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category c)
        {
            var createCategory = await _category.AddAsync(c);

            if (createCategory)
            {
                Alert("Category Created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Category not Created!", NotificationType.error);
            }
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        //[HttpDelete] Cos there is no view for Delete
        public async Task<IActionResult> Delete(int id)
        {
            var deletecategory = await _category.Delete(id);
            if (deletecategory)
            {
                Alert("Category Deleted successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Category not Deleted!", NotificationType.error);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category c)
        {
            var editCat = await _category.Update(c);
            if (editCat && ModelState.IsValid)
            {
                Alert("Category Edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else {
                Alert("Category not Edited!", NotificationType.error);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editCat = await _category.GetById(id);
            if (editCat == null)
            {
                return RedirectToAction("Index");
            }
            return View(editCat);
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "Category");
        }
    }
}
