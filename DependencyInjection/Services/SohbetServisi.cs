using DependencyInjection.Models;

namespace DependencyInjection.Services
{
	public class SohbetServisi
	{
		private int sonEklenenId = 0;

		private List<Mesaj> Mesajlar { get; set; } = new List<Mesaj>();

		public SohbetServisi()
		{
			MesajEkle("Site Admini", "Merhaba");
			MesajEkle("Site Admini", "Sohbet uygulamamıza hoşgeldiniz..");
		}

		public void MesajEkle(string gonderen, string icerik)
		{
			Mesajlar.Add(new Mesaj()
			{
				Id = ++sonEklenenId,
				Gonderen = gonderen,
				Icerik = icerik
			});
		}

		public List<Mesaj> MesajlariGetir()
		{
			return Mesajlar.OrderByDescending(x => x.Id).ToList();
		}
	}
}
