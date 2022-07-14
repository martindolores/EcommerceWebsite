using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebsite.Data;
using EcommerceWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace EcommerceWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TagNameController : Controller
    {
        private ApplicationDbContext _db;

        public TagNameController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.TagNames.ToList());
        }

        //Create Get Action Method
        public ActionResult Create()
        {
            return View();
        }

        //Create Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TagName tagName)
        {
            if (ModelState.IsValid)
            {
                _db.TagNames.Add(tagName);
                await _db.SaveChangesAsync();
                TempData["save"] = "Tag Name has been saved!";
                return RedirectToAction(actionName: nameof(Index));
            }

            return View(tagName);
        }

        //GET Edit Action Method
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tagNames = _db.TagNames.Find(id);
            if (tagNames == null)
            {
                return NotFound();
            }
            return View(tagNames);
        }

        //POST Edit Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TagName tagName)
        {
            if (ModelState.IsValid)
            {
                _db.Update(tagName);
                await _db.SaveChangesAsync();
                return RedirectToAction(actionName: nameof(Index));
            }

            return View(tagName);
        }

        //GET Details Action Method
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tagName = _db.TagNames.Find(id);
            if (tagName == null)
            {
                return NotFound();
            }
            return View(tagName);
        }

        //POST Details Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(TagName tagName)
        {
            return RedirectToAction(actionName: nameof(Index));
        }


        //GET Delete Action Method
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tagName = _db.TagNames.Find(id);
            if (tagName == null)
            {
                return NotFound();
            }
            return View(tagName);
        }

        //POST Delete Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, TagName tagName)
        {
            var tagNames = _db.TagNames.Find(id);
            if (id == null || id != tagName.Id || tagNames == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _db.Remove(tagNames);
                await _db.SaveChangesAsync();
                TempData["delete"] = "Tag Name has been deleted!";
                return RedirectToAction(actionName: nameof(Index));
            }

            return View(tagName);
        }
    }
}
