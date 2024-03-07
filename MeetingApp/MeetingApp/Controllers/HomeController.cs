using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeetingApp.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			int UserCount= Repository.Users.Where(x => x.WhillAttend == true).Count();//Kat�lacak olanlar�n say�s�
			int saat = DateTime.Now.Hour;
			var selamlama = saat > 12 ? "�yi G�nler" : "G�nayd�n";
			ViewBag.Selamlama=selamlama;
			var meetinginfo = new MeetingInfo()
			{
				Id = 1, Location = "D�zce", Date = new DateTime(2024, 01, 20, 20, 0, 0),/*20/01/2024/20:00*/NumberOfPeople = UserCount,
			};
			//ViewData["Selamlama"] = selamlama; kar��dada @ViewData["Selamlama"] yazarak veri al�nabilir.
			return View(meetinginfo);//Buraya direkt olarak selamlama yazarsan home i�erinde Selamlama.cshtml ad�nda klas�r ara ve hata al�rs�n bu y�zden model:selamlama yazars�n
		}

		public IActionResult Privacy()
		{
			return View();
		}
	}
}
