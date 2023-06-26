using System;
namespace basicCalculator
{
	public class Matematik
	{
		public decimal Toplamaİslemi(decimal sayi1, decimal sayi2)
		{
            decimal sonuc = sayi1 + sayi2;
			return sonuc;
		}
		public decimal Cikarmaİslemi(decimal sayi1, decimal sayi2)
		{
            decimal sonuc = sayi1 - sayi2;
			return sonuc;
		}
		public decimal Bölmeİslemi(decimal sayi1, decimal sayi2)
		{
			decimal sonuc = sayi1 / sayi2;
			return sonuc;
		}
		public decimal Carpmaİslemi(decimal sayi1, decimal sayi2)
		{
            decimal sonuc = sayi1 * sayi2;
			return sonuc;
		}
		public void Menu()
		{
			Console.Clear();
			Console.WriteLine("*** MENU ***");
			Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Bölme");
            Console.WriteLine("4 - Çarpma");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
        }
		public void sonucEkranaYaz(decimal kullaniciSayi1, decimal kullaniciSayi2, decimal sonuc, string operators)
		{
			Console.WriteLine("{0} {1} {2} = {3}", kullaniciSayi1, operators, kullaniciSayi2, sonuc);
		}
	}
}

