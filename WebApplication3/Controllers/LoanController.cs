using System;
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
    public class LoanController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Loan
        [Authorize]
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            List<Loan> loans = db.Loan.Where(c => c.ApplicationUserId == userId).ToList();
            return View(loans);
        }

        // GET: Loan/Details/5
        public ActionResult Details(int id)
        {
            var userId = User.Identity.GetUserId();
            var loan = db.Loan.Where(c => c.Id == id).SingleOrDefault();
            return View(loan);
        }

        // GET: Loan/Create
        [Authorize]
        public ActionResult Create()
        {
            var userId = User.Identity.GetUserId();
            ViewBag.UserId = userId;
            return View();
        }

        // POST: Loan/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        public ActionResult Create(Loan loan)
        {
            var userId = User.Identity.GetUserId();
            loan.ApplicationUserId = userId;
            try
            {
                db.Loan.Add(loan);
                db.SaveChanges();
                return RedirectToAction("Create", "Loan");
            }
            catch
            {
                return View();
            }
        }

        // GET: Loan/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            var userId = User.Identity.GetUserId();
            var loan = db.Loan.Where(c => c.Id == id).SingleOrDefault();
            return View(loan);
        }

        // POST: Loan/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        public ActionResult Edit(int id, Loan loanaccount)
        {
            try
            {
                // TODO: Add update logic here
                var userId = User.Identity.GetUserId();
                var loan = db.Loan.Where(c => c.Id == id).SingleOrDefault();
                try
                {
                    loan.ApplicationUserId = userId;
                    loan.LoanTerm = loanaccount.LoanTerm;
                    loan.LoanAmount = loanaccount.LoanAmount;
                    loan.LoanInterestRate = loanaccount.LoanInterestRate;
                    loan.LoanName = loanaccount.LoanName;
                    loan.LoanDate = loanaccount.LoanDate;
                    loan.Id = id;
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

        // GET: Loan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Loan/Delete/5
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
