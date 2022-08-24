// See https://aka.ms/new-console-template for more information
//Do not repeat yourself - DRY
//Clean Code 
//Best Practice - Doğru uygulama teknikleri
//cs C# ın kısaltılması

using Metodlar;


Urun urun1 = new Urun();
urun1.Adi = "Elma";
urun1.Fiyati = 15;
urun1.Aciklama = "Amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyati = 80;
urun2.Aciklama = "Diyarbakır karpuzu";

Urun[] urunler = new Urun[] {urun1,urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    
    Console.WriteLine("-------------");
}

Console.WriteLine("--------Metodlar-----------");
//Encapsulatıon : kapsülleme


SepetManager SepetManager = new SepetManager();
SepetManager.Ekle(urun1);
SepetManager.Ekle(urun2);

SepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
SepetManager.Ekle2("Elma ", "Yeşil elma", 18,5);
SepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 22,8);


