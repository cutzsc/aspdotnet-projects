using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult RsvpForm()
		{
			return View();
		}

		[HttpPost]
		public IActionResult RsvpForm(GuestResponse guestResponse)
		{
			if (ModelState.IsValid)
			{
				Repository.AddResponse(guestResponse);
				return View("Thanks", guestResponse);
			}
			return View();
		}

		public IActionResult ListResponses()
		{
			return View(Repository.Responses.Where(item => item.WillAttend == true));
		}
	}
}
