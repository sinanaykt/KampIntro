namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fİyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fİyati = 150;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[]{urun1,urun2};
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fİyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");

            }

            Console.WriteLine("----------Metotlar-------------");
            
            // instence - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12);
            sepetManager.Ekle2("karpuz", "Diyarbakır karpuzu", 12);

        }
    }
}


//Dont repeat yourself - DRY - Clean Code -Best Practice