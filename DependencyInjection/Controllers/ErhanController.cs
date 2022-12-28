using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
	public class ErhanController : Controller
	{
		public IActionResult Index([FromServices] RastgeleSayiServisi rss)
		{
			ViewBag.Sansli = rss.Aralik(1, 33);
			ViewBag.OlusmaZamani = rss.ServisinOlusturulmaZamani.ToString("o");
			return View();
		}
	}
}
