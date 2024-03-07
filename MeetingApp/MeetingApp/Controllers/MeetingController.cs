using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
	public class MeetingController : Controller
	{
		//public IActionResult Index()
		//{
		//	return View();ihtiyaç kalmadı
		//}
		[HttpGet]
		public IActionResult Apply()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Apply(UserInfo model)
		{
			if(ModelState.IsValid)
			{
                //database kaydı yapılabilir
                Repository.CreateUser(model);
                ViewBag.UserCount = Repository.Users.Where(x => x.WhillAttend == true).Count();//Katılacak olanların sayısı
                return View("Thanks", model);
            }
			else
			{
				return View(model);
			}
		}
		public IActionResult List()
		{
			var users=Repository.Users;
			return View(users);
		}

		//meeting/details/1
		public  IActionResult Details(int id)
		{

			return View(Repository.GetbyId(id));
		} 
	}
}
