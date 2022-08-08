using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplicationConsumeAPI.Models;

namespace WebApplicationConsumeAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Customer> emp = new List<Customer>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44341/");
            HttpResponseMessage response = await client.GetAsync("api/Customer/GetAllCustomer");
            if(response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                emp = JsonConvert.DeserializeObject<List<Customer>>(result); 
            }
            return View(emp);
        }

        public async Task<IActionResult> AllBook()
        {
            List<BookModel> emp = new List<BookModel>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44341/");
            HttpResponseMessage response = await client.GetAsync("api/Books/AllBook");
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                emp = JsonConvert.DeserializeObject<List<BookModel>>(result);
            }
            return View(emp);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return View();
        }
    }
}
