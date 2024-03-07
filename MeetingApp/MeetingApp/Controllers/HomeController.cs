using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetingApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			int UserCount= Repository.Users.Where(x => x.WhillAttend == true).Count();//Katýlacak olanlarýn sayýsý
			int saat = DateTime.Now.Hour;
			var selamlama = saat > 12 ? "Ýyi Günler" : "Günaydýn";
			ViewBag.Selamlama=selamlama;
			var meetinginfo = new MeetingInfo()
			{
				Id = 1, Location = "Düzce", Date = new DateTime(2024, 01, 20, 20, 0, 0),/*20/01/2024/20:00*/NumberOfPeople = UserCount,
			};
			//ViewData["Selamlama"] = selamlama; karþýdada @ViewData["Selamlama"] yazarak veri alýnabilir.
			return View(meetinginfo);//Buraya direkt olarak selamlama yazarsan home içerinde Selamlama.cshtml adýnda klasör ara ve hata alýrsýn bu yüzden model:selamlama yazarsýn
		}

		public IActionResult Privacy()
		{
			return View();
		}
	}
}
