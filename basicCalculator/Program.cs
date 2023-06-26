namespace basicCalculator;
class Program
{
    static void Main(string[] args)
    {
        Matematik M = new Matematik();
        YenidenIslemYap:
        M.Menu();
        int kullaniciSecim = int.Parse(Console.ReadLine());

        Console.WriteLine("Lütfen işlem yapmak istediğiniz 1. sayı değerini giriniz: ");
        decimal kullaniciSayi1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Lütfen işlem yapmak istediğiniz 2. sayı değerini giriniz: ");
        decimal kullaniciSayi2 = decimal.Parse(Console.ReadLine());

        decimal sonuc = 0;

        switch (kullaniciSecim)
        {
            case 1: //Toplama
                sonuc = M.Toplamaİslemi(kullaniciSayi1, kullaniciSayi2);
                M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "+");
                break;

            case 2: //Çıkarma
                sonuc = M.Cikarmaİslemi(kullaniciSayi1, kullaniciSayi2);
                M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "-");
                break;

                case 3: //Bölme
                sonuc = M.Bölmeİslemi(kullaniciSayi1, kullaniciSayi2);
                M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "/");
                break;

                case 4: //Çarpma
                sonuc = M.Carpmaİslemi(kullaniciSayi1, kullaniciSayi2);
                M.sonucEkranaYaz(kullaniciSayi1, kullaniciSayi2, sonuc, "*");
                break;

            default:
                Console.WriteLine("Belirtmiş olduğunuz değer liste içinde bulunamadı.");
                Console.WriteLine(" Lütfen tekrar deneyiniz.");
                System.Threading.Thread.Sleep(2000);
                goto YenidenIslemYap;
                break;
        }
        Console.WriteLine("Yeniden işlem yapmak ister misiniz? [E / H] ");
        string secim = Console.ReadLine();

        if (secim.ToUpper() == "E") 
        {
            goto YenidenIslemYap;
        }

    }

}



  







