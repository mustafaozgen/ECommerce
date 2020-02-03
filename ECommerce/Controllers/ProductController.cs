using ECommerce.Models;
using ECommerceData;
using ECommerceData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        private IProduct _products;
        public ProductController(IProduct products)
        {
            _products = products;
        }

        public IActionResult Index()
        {
            var productModels = _products.GetAllProducts();
            var listingResult = productModels
                .Select(result => new ProductIndexListingModel
                {
                    Id = result.Id,
                    Title = result.Title,
                    Price = result.Price
                    //CategoryId = _products.GetCategoryId(result.Id)
                });
            var model = new ProductIndexModel()
            {
                Products = listingResult
            };
            return View(model);
        }

        public IActionResult Detail(int id)
        {
            var product = _products.GetProduct(id);
            var model = new ProductDetailModel
            {
                ProductId = id,
                Title = product.Title,
                Price = product.Price
                //CategoryName = _products.Category.Title
            };
            return View(model);
        }

        public IActionResult CheckOut()
        {
            Models.ShoppingCart cart = new Models.ShoppingCart();
            string json = HttpContext.Session.GetString("shoppingCart");
            var productList = JsonConvert.DeserializeObject<Models.ShoppingCart>(json);

            Dictionary<string, int> newDictionary = new Dictionary<string, int>();
            var productCount = 0;
            Dictionary<int, int> dictionaryCounts = new Dictionary<int, int>();
            Sepet sepet = new Sepet();
          
            foreach (int i in productList.ProductsIdList)
            {
                int count;
                if (dictionaryCounts.TryGetValue(i, out count))
                {
                    dictionaryCounts[i] = count + 1;
                    productCount++;
                    newDictionary[_products.GetTitle(i)] = count + 1;
                }
                else
                {
                    dictionaryCounts.Add(i, 1);
                    var productId = productList.ProductsIdList[0];
                    newDictionary.Add(_products.GetTitle(i), 1);
                }
            }

            foreach(var i in dictionaryCounts)
            {
                Product product = new Product();
                product = _products.GetProduct(i.Key);
                SepetDetay sptDetay = new SepetDetay();
                sptDetay.product = new ProductDetailModel();
                sptDetay.product.ProductId = product.Id;
                sptDetay.product.Title = product.Title;
                sptDetay.product.Price = product.Price;
                sptDetay.Quantity = i.Value;
                sepet.sepetDetayList.Add(sptDetay);
            }
            return View(sepet);
        }

        public IActionResult AddToCart(AddToCartBindingModel model)
        {
            Models.ShoppingCart cart;
            if (HttpContext.Session.Keys.Contains("shoppingCart"))
            {
                string json = HttpContext.Session.GetString("shoppingCart");
                cart = JsonConvert.DeserializeObject<Models.ShoppingCart>(json);
            }
            else
            {
                cart = new Models.ShoppingCart();
            }

            for (int i = 0; i < model.Quantity; i++)
            {
                cart.ProductsIdList.Add(model.ProductId);
            }
            HttpContext.Session.SetString("shoppingCart", JsonConvert.SerializeObject(cart));

            return RedirectToAction("Index");

        }
    }

    public class AddToCartBindingModel
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
