// See https://aka.ms/new-console-template for more information
//Birbirine benzeyen işleri yapmak için döngüler kullanılır.Tekrar eden yapılar

//Array - dizi

string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı ", "Programlamaya başlangıç için temel kurs","Java","Phyton"};

for (int i  = 0; i  < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("For bitti.");

foreach (string kurs in kurslar)//in kurslar : Kurslar'ı dolaş.
{
    Console.WriteLine(kurs);//dizileri tek tek dolaşmaya yarar
}


Console.WriteLine("Sayfa sonu - footer");





