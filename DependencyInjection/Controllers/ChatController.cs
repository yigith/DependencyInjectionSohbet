using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
	public class ChatController : Controller
	{
		private readonly SohbetServisi _sohbetServisi;

		public ChatController(SohbetServisi sohbetServisi)
		{
			_sohbetServisi = sohbetServisi;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MesajlarPartial()
        {
            return PartialView("_Mesajlar");
        }

        [HttpPost]
		public IActionResult Gonder(Mesaj mesaj)
		{
			if (ModelState.IsValid)
			{
				_sohbetServisi.MesajEkle(mesaj.Gonderen, mesaj.Icerik);
				return Ok(); // durum kodu 200
			}
			return BadRequest(); // durum kodu 400
		}
	}
}
