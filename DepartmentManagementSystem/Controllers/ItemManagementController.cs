﻿using DepartmentManagementSystem.Data;
using DepartmentManagementSystem.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DepartmentItemManagement.Controllers
{

    public class ItemManagementController : Controller
    {
        private readonly ItemDb itemdb;

        public ItemManagementController(ItemDb itemdb)
        {
            this.itemdb = itemdb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var item = itemdb.Items.ToList();
            return View(item);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(AddItem additem)
        {
            var newitem = new Item()
            {
                Name = additem.Name,
                Description = additem.Description,  
                Category = additem.Category,
                Price = additem.Price,

            };
            itemdb.Items.Add(newitem);
            itemdb.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult View(int Id)
        {
            var newitem = itemdb.Items.FirstOrDefault(x => x.Id == Id);
            if (newitem != null)
            {
                var item = new UpdateItem()
                {
                    Id = newitem.Id,
                    Name = newitem.Name,
                    Description = newitem.Description,  
                    Category = newitem.Category,
                    Price = newitem.Price,
                };
                return View("View", item);
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult View(UpdateItem updateitem)
        {
            var newitem = itemdb.Items.Find(updateitem.Id);
            if (newitem != null)
            {
                newitem.Name = updateitem.Name;
                newitem.Category = updateitem.Category;
                newitem.Price = updateitem.Price;
                itemdb.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var item = itemdb.Items.FirstOrDefault(item => item.Id == id);
            if (item != null)
            {
                itemdb.Items.Remove(item);
                itemdb.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}