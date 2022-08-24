// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "Java";
kurs1.Egitmen = "Kerem Varış";
kurs1.İzlenmeOrani = 64;


Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Python";
kurs2.Egitmen = "Berkay Bilgin";
kurs2.İzlenmeOrani = 80;


Kurs kurs3 = new Kurs();
kurs3.KursAdi = "C#";
kurs3.Egitmen = "Engin Demiroğ";
kurs3.İzlenmeOrani = 68;

//Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen + " " + kurs1.İzlenmeOrani + " % TAMAMLANDI");

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};//Ekran kısmı : görünen kısım



foreach ( Kurs kurs  in kurslar)
{
    Console.WriteLine(kurs.KursAdi + " : " + kurs1.Egitmen + " " + kurs1.İzlenmeOrani + " % TAMAMLANDI");
}
    




class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int İzlenmeOrani { get; set; }
}
