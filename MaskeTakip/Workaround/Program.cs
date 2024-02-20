// See https://aka.ms/new-console-template for more information

//string mesaj = "merhaba";
//double tutar = 1000000;
//int sayi = 100;
//bool girisYapmisMi= false;

//string ad = "Nur";
//string soyad = "Şenol";
//int dogumYili = "2003";
//long tcNo = "53626668362";

//Console.WriteLine(tutar * 1.18);

using Business.Concrete;
using Entities.Concrete;
using System.Globalization;
using System.Reflection.Metadata;

Vatandas vatandas1 = new Vatandas();

SelamVer("NUR");
SelamVer();
int sonuc=Topla(5, 3);

//DİZiLER / Arrays
string[] ogrenciler = new string[3];
ogrenciler[0] = "Şeyma";
ogrenciler[1] = "beyza";
ogrenciler[2] = "ali";

ogrenciler = new string[4];
ogrenciler[3] = "ilker";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler = new[] { "ankara", "istanbul", "izmir" };
string[] sehirler2 = new[] { "Bursa", "antalya", "diyarbakır" };
sehirler2 = sehirler;
sehirler[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Engin";
person1.LastName = "Demiroğ";
person1.DateOfBirthYear = 1985;
person1.NationalIdentity = 123;

Person person2 = new Person();
person2.FirstName = "Murat";

foreach (string sehirr in sehirler2)
{
    Console.WriteLine(sehirler2);

}

List<string> YeniSehirler1 = new List<string> {"Ankara1","İstanbul1","İzmir1" };
YeniSehirler1.Add("Kocaeli1");

foreach (string sehir in YeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager( new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();


static void SelamVer(string isim="isimsiz") 
{
    Console.WriteLine("Merhaba "+ isim);
   


}


static int Topla(int sayi1, int sayi2) 
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam: "+ sonuc);
    return sonuc; 
}


public class Vatandas
{

    public string Ad { get; set; }

    public string Soyad { get; set; }

    public int DogumYili { get; set; }

    public long TcNo { get; set; }
}



