﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceWebsite.Data;
using EcommerceWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceWebsite.Areas.Customer.Controllers
{
    [Area("Customer")]

    public class UserController : Controller
    {
        UserManager<IdentityUser> _userManager;
        ApplicationDbContext _db;
        public UserController(UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.ApplicationUser.ToList());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                user.Email = user.UserName;
                user.NormalizedEmail = user.Email.ToUpper();
                user.EmailConfirmed = true;
                var result = await _userManager.CreateAsync(user, user.PasswordHash);
                if (result.Succeeded)
                {

                    var isSaveRole = await _userManager.AddToRoleAsync(user,role: "Customer");
                    TempData["save"] = "User has been created successfully!";
                    return RedirectToAction(nameof(Index));
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                
            }
            return View();
        }

        //GET Edit Action Method
        public async Task<IActionResult> Edit(string id)
        {
            var users = _db.ApplicationUser.FirstOrDefault(c => c.Id == id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        //POST Edit Action Method
        [HttpPost]
        public async Task<IActionResult> Edit(ApplicationUser user)
        {
            var userInfo = _db.ApplicationUser.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();
            }
            userInfo.FirstName = user.FirstName;
            userInfo.LastName = user.LastName;
            var result = await _userManager.UpdateAsync(userInfo);
            if (result.Succeeded)
            {
                TempData["save"] = "User has been updated successfully!";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        //GET Details Action Method
        public async Task<IActionResult> Details(string id)
        {
            var users = _db.ApplicationUser.FirstOrDefault(c => c.Id == id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }

        //GET Lock Action Method
        public async Task<IActionResult> Lock(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = _db.ApplicationUser.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        //POST Lockout Action Method
        [HttpPost]
        [ActionName("Lock")]
        public async Task<IActionResult> LockUser(ApplicationUser user)
        {
            var userInfo = _db.ApplicationUser.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();
            }
            userInfo.LockoutEnd = DateTime.Now.AddYears(100);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                TempData["delete"] = "User has been Locked successfully!";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }

        //GET Active Action Method
        public async Task<IActionResult> Active(string id)
        {
            var user = _db.ApplicationUser.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        //POST Active Action Method
        [HttpPost]
        [ActionName("Active")]
        public async Task<IActionResult> ActivateUser(ApplicationUser user)
        {
            var userInfo = _db.ApplicationUser.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();
            }
            userInfo.LockoutEnd = null;
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                TempData["save"] = "User has been activated successfully!";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }

        //GET Delete Action Method
        public async Task<IActionResult> Delete(string id)
        {
            var user = _db.ApplicationUser.FirstOrDefault(c => c.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        //POST Delete Action Method
        [HttpPost]
        public async Task<IActionResult> Delete(ApplicationUser user)
        {
            var userInfo = _db.ApplicationUser.FirstOrDefault(c => c.Id == user.Id);
            if (userInfo == null)
            {
                return NotFound();
            }
            _db.ApplicationUser.Remove(userInfo);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                TempData["delete"] = "User has been deleted successfully!";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }


    }
}
