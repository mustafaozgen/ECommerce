using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using ECommerceData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers
{
    public class CampaignsController : Controller
    {
        private ICampaigns _campaigns;
        public CampaignsController(ICampaigns campaigns)
        {
            _campaigns = campaigns;
        }

        // GET: Campaigns
        public IActionResult Index()
        {
            var campaignsModels = _campaigns.GetAllCampaigns();

            var listingResult = campaignsModels
                .Select(result => new CampaignsIndexListingModel
                {
                    Id = result.Id,
                    DiscountRate = result.DiscountRate,
                    DiscountType = result.DiscountType,
                    MinimumProductQuantity = result.MinimumProductQuantity
                });
            var model = new CampaignsIndexModel()
            {
                Campaigns = listingResult
            };
            return View(model);
        }

        // GET: Campaigns/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: Campaigns/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Campaigns/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Campaigns/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: Campaigns/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Campaigns/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: Campaigns/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}