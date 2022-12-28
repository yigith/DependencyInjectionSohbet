namespace DependencyInjection.Services
{
    public class RastgeleSayiServisi
    {
        public DateTime ServisinOlusturulmaZamani { get; } = DateTime.Now;

        static Random rnd = new Random();

        public int ZarAt()
        {
            return rnd.Next(1, 7);
        }

        public int Aralik(int min, int max)
        {
            return rnd.Next(min, max + 1);
        }

        public int[] Aralik(int min, int max, int adet)
        {
            List<int> sayilar = new List<int>();

            for (int i = 0; i < adet; i++)
            {
                int rastgele;
                do
                {
                    rastgele = Aralik(min, max);

                } while (sayilar.Contains(rastgele));
                sayilar.Add(rastgele);
            }

            return sayilar.ToArray();
        }
    }
}
