using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Thailand.Addresses.Core;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ThailandAddresses thailandAddresses = new ThailandAddresses();
            ViewBag.Region = thailandAddresses.GetRegionToJson();
            ViewBag.Province = thailandAddresses.GetProvinceToJson();
            ViewBag.Postcode = thailandAddresses.GetPostcodeToJson();
            ViewBag.District = thailandAddresses.GetDistrictToJson();
            ViewBag.SubDistrict = thailandAddresses.GetSubDistrictToJson();
            ViewBag.FindAddress = thailandAddresses.FindAddressByTextToJson("Bangkok");
            var list = thailandAddresses.FindAddressByTextToList("Bangkok");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
