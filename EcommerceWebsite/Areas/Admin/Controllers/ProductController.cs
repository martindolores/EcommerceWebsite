using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebsite.Data;
using EcommerceWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EcommerceWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private ApplicationDbContext _db;
        private IWebHostEnvironment _he;

        public ProductController(ApplicationDbContext db, IWebHostEnvironment he)
        {
            _db = db;
            _he = he;
        }
        public IActionResult Index()
        {
            return View(_db.Products.Include(c => c.ProductTypes).Include(f => f.TagName).ToList());
        }

        //GET Create Action Method
        public IActionResult Create()
        {
            ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
            ViewData["TagId"] = new SelectList(_db.TagNames.ToList(), "Id", "TagNames");
            return View();
        }

        //Post Create Action Method
        [HttpPost]
        public async Task<IActionResult> Create(Products products, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                var searchProduct = _db.Products.FirstOrDefault(c => c.Name == products.Name);
                if (searchProduct != null)
                {
                    TempData["exist"] = "This product already exists.";
                    ViewBag.Message = "This product already exists.";
                    ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
                    ViewData["TagId"] = new SelectList(_db.TagNames.ToList(), "Id", "TagNames");
                    return View(products);
                }
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }
                else if (image == null)
                {
                    products.Image = "images/image-not-found.png";
                }
                _db.Products.Add(products);
                await _db.SaveChangesAsync();
                TempData["save"] = "Product has been saved!";
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }

        //GET Edit Action Method
        public ActionResult Edit(int? id)
        {
            ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
            ViewData["TagId"] = new SelectList(_db.TagNames.ToList(), "Id", "TagNames");
            var product = _db.Products.Include(c => c.ProductTypes).Include(c => c.TagName)
                .FirstOrDefault(c => c.Id == id);
            if(product == null || id == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //POST Edit Action Method
        [HttpPost]
        public async Task<IActionResult> Edit(Products products, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }
                else if (image == null)
                {
                    products.Image = "images/image-not-found.png";
                }
                _db.Products.Update(products);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(products);
        }

        //GET Details Action Method
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.ProductTypes).
                Include(c => c.TagName).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        //GET Delete Action Method
        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.ProductTypes).
                Include(c => c.TagName).Where(c => c.Id == id).FirstOrDefault();
            if (product ==null)
            {
                return NotFound();
            }
            return View(product);
        }

        //POST Delete Action Method
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Products.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            TempData["delete"] = "Product has been deleted!";
            return RedirectToAction(nameof(Index));
        }

    }
}
