using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSMS.ViewModels;
using TSMS.Service.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace TSMS.Controllers
{
    public class AdminController : Controller
    {
        private IUserService _userService;

        public AdminController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/CreateCustomer
        public IActionResult CreateCustomer()
        {

            return View();
        }

        // POST: Admin/CreateCustomer
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCustomer(CreateUserViewModel newCustomerModel)
        {
             
           if(ModelState.IsValid)
            {
              IdentityResult result =  await _userService.CreateUser(newCustomerModel);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                AddErrors(result);
              
            }

            
                return View();
            
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }



    }
}