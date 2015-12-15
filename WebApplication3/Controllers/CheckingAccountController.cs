using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using Microsoft.AspNet.Identity;


namespace WebApplication3.Controllers
{
    public class CheckingAccountController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        
        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            List<CheckingAccount> checkingAccounts = db.CheckingAccounts.Where(c => c.ApplicationUserId == userId).ToList();
          
            decimal totalAccount = 0;
            foreach (var balance in checkingAccounts)
            {
                totalAccount += balance.Balance;
            }
            ViewBag.TotalOfAccount = totalAccount;
            return View(checkingAccounts);
        }
        // GET: CheckingAccount
        //[Authorize]
        //public ActionResult Index(int checkingAccountId)
        //{
            
        //    var accountBalance = db.CheckingAccounts.Find(db.CheckingAccounts.)
        //    return View();
        //}

         

        // GET: CheckingAccount/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CheckingAccount/Create
        [Authorize]
        public ActionResult Create()
        {
            var userId = User.Identity.GetUserId();
            ViewBag.UserId = userId;
            return View();
        }

        // POST: CheckingAccount/Create
        [Authorize]
        [HttpPost]
        public ActionResult Create(CheckingAccount checkingaccount)
        {
            var userId = User.Identity.GetUserId();
            checkingaccount.ApplicationUserId = userId;
            try
            {
                db.CheckingAccounts.Add(checkingaccount);
                db.SaveChanges();
                return RedirectToAction("Create", "CheckingAccount");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckingAccount/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            var userId = User.Identity.GetUserId();
            var checking = db.CheckingAccounts.Where(c => c.Id == id).SingleOrDefault();
            return View(checking);
        }

        // POST: CheckingAccount/Edit/5
        [Authorize]
        [HttpPost]
        public ActionResult Edit(int id, CheckingAccount checkingaccount)
        {
            try
            {
                // TODO: Add update logic here
                var userId = User.Identity.GetUserId();
                var checking = db.CheckingAccounts.Where(c => c.Id == id).SingleOrDefault();
                try
                {
                    checking.ApplicationUserId = userId;
                    checking.Balance = checkingaccount.Balance;
                    checking.CheckingName = checkingaccount.CheckingName;
                    checking.Id = id;
                }
                catch
                {
                    return View();
                }

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CheckingAccount/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CheckingAccount/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
    }
}
