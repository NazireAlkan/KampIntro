// See https://aka.ms/new-console-template for more information
//type safety = tip güvenliği
//Do not repeat yourself
//Değişkenler : değer tutucu,alias
string kategoriEtiketi = "Kategoriler";
int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmisMi = true;


double dolarDun = 7.74;
double dolarBugun = 7.74;

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else if (dolarDun<dolarBugun) 
{
    Console.WriteLine("Artış butonu");
}
else 
{
    Console.WriteLine("Değişmedi butonu");
}



if (sistemeGirisYapmisMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");

}


Console.WriteLine(kategoriEtiketi);
