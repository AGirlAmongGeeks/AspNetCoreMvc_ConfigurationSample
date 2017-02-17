using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Extensions.Configuration;
using ConfigurationSample.Helpers;
using ConfigurationSample.Model;
using Microsoft.Extensions.Options;

namespace ConfigurationSample.Controllers
{
    public class HomeController : Controller
    {
		private EmailMessages EmailMessages { get; set; }

		public HomeController(IOptions<EmailMessages> config)
		{
			EmailMessages = config.Value;
		}

		public IActionResult Index()
        {
			#region Retrieve configuration (connection string) in traditional way.
			var configuration = ConfigurationHelper.GetConfiguration(Directory.GetCurrentDirectory());

			//3 ways to get the same configuration.
			var connectionString = configuration.GetConnectionString("DefaultConnection");
			var connectionString2 = configuration.GetSection("ConnectionStrings")["DefaultConnection"];
			var connectionString3 = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
			#endregion

			#region Strongly typed configuration.
			var firstMessage = EmailMessages.FirstMessage;

			#endregion

			return View();
        }
    }
}
