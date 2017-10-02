using ProjectOnSalesTracker.Models;
using ProjectOnSalesTracker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOnSalesTracker.Controllers
{
    public class TrackerController : Controller
    {
        TrackerContext _db = new TrackerContext();
        // GET: Tracker
        [HttpGet]
        public ActionResult Index()
        {
            var Buyer = _db.BuyerInfoes.ToList();
            var Product = _db.Product.ToList();
            var Source = _db.Source.ToList();
            var Website = _db.website.ToList();
            var status = _db.Status.ToList();
            var BuyerData = new BuyerData()
            {
                BuyerInfo = Buyer,
                Product = Product,
                Source = Source,
                website = Website,
                Status = status

            };
         

                
          
            return View(BuyerData);
           
        }
        [HttpGet]
        public ActionResult BuyerEntry()
        {
            var Product = _db.Product.ToList();
            
          //  ViewBag.Product = new SelectList(Product);

            BuyerInfo buyerinfo = new BuyerInfo();
            Product product = new Product();
            CommunicationMedium medium = new CommunicationMedium();
            CommunicationFrom communicator = new CommunicationFrom();
            website web = new website();
            Source source = new Source();
            Communication communication = new Communication();
            
            return View(buyerinfo);
        }
        [HttpPost]
        public ActionResult BuyerEntry(BuyerInfo buyerinfo)
        {
           
        

        _db.BuyerInfoes.Add(buyerinfo);
            _db.SaveChanges();
            return RedirectToAction("ThankYou", "Tracker");
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            Product model = new Product();
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product model )
        {
            _db.Product.Add(model);
            _db.SaveChanges();
            return RedirectToAction("ThankYou", "Tracker");
        }
        [HttpGet]
        public ActionResult AddSource()
        {
            Source model = new Source();
            return View();
        }
        [HttpPost]
        public ActionResult AddSource(Source model)
        {
            _db.Source.Add(model);
            _db.SaveChanges();
            return RedirectToAction("ThankYou", "Tracker");
        }
        [HttpGet]
        public ActionResult Addwebsite()
        {
            website model = new website();
            return View();
        }
        [HttpPost]
        public ActionResult Addwebsite(website model)
        {
            _db.website.Add(model);
            _db.SaveChanges();
            return RedirectToAction("ThankYou", "Tracker");
        }
        [HttpGet]
        public ActionResult AddMedium()
        {
            CommunicationMedium model = new CommunicationMedium();
            return View();
        }
        [HttpPost]
        public ActionResult AddMedium(CommunicationMedium model)
        {
            _db.CommunicationMedium.Add(model);
            _db.SaveChanges();
            return RedirectToAction("ThankYou", "Tracker");
        }

        [HttpGet]
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}