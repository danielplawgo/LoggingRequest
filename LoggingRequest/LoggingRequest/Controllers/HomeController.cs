using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;
using Random = System.Random;

namespace LoggingRequest.Controllers
{
    public class HomeController : Controller
    {
        private static ILogger _logger = NLog.LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            _logger.Info("Home.Index started.");

            Random random = new Random();
            var value = random.Next(1, 3);
            _logger.Info($"Home.Index value is equal {value}");

            if (value == 1)
            {
                _logger.Error("Error during processing value");
                throw new Exception("Error during processing value");
            }

            _logger.Info("Home.Index ended.");
            return View();
        }
    }
}