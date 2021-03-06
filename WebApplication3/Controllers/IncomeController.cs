﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using Microsoft.AspNet.Identity;

namespace WebApplication3.Controllers
{
    public class IncomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            List<Income> income = db.Incomes.Where(c => c.ApplicationUserId == userId).ToList();
            return View(income);
        }
        // GET: Income
        //public ActionResult Index()
        // {
        //      var incomes = db.Incomes.Include(i => i.User);
        //      return View(incomes.ToList());
        //  }

        // GET: Income/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Income/Create
        [Authorize]
        public ActionResult Create()
        {
            var userId = User.Identity.GetUserId();
            ViewBag.UserId = userId;
            return View();
        }

        // POST: Income/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        public ActionResult Create(Income income)
        {
            var userId = User.Identity.GetUserId();
            income.ApplicationUserId = userId;
            try
            {
                db.Incomes.Add(income);
                db.SaveChanges();
                return RedirectToAction("Create", "Income");
            }
            catch
            {
                return View();
            }
        }

        // GET: Income/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Income/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Income/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Income/Delete/5
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
