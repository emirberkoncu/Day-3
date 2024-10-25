using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace koleksiyonlar;

class Program
{
    static void Main(string[] args)
    {

        //* ******************************************* Dictionary ***********************************
        //* system.collecitons.generic
        // Dictionary<key,value>
        Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
        kullanıcılar.Add(10,"Emir Oncu");
        kullanıcılar.Add(11,"Basak Oncu");
        kullanıcılar.Add(18,"Sadık Efe");
        kullanıcılar.Add(20,"Yagmur Su");

        //* Elemanlara Erişim
        Console.WriteLine("********* Elemanlara Erişim *********");

        Console.WriteLine(kullanıcılar[10]); //! Erişmek istediğimiz elemanın "key" değerini yazıyoruz

        foreach (var kullanıcı in kullanıcılar)
        {  
            Console.WriteLine(kullanıcı); 
        }

        //* Count 
        Console.WriteLine("********* Count *********");
        Console.WriteLine(kullanıcılar.Count);

        //* Contains
        Console.WriteLine("********* Contains *********");
        Console.WriteLine(kullanıcılar.ContainsKey(11)); //11 numaralı key var mı? --> Bool Döner
        Console.WriteLine(kullanıcılar.ContainsValue("Basak Emir")); //Basak Emir value var mı? --> Bool Döner


        //* Remove
        Console.WriteLine("********* Remove *********");
        kullanıcılar.Remove(11);
        foreach (var kullanıcı in kullanıcılar)
        {
            Console.WriteLine(kullanıcı);
        }

        //* Keys
        Console.WriteLine("********* Keys *********");
        foreach (var item in kullanıcılar.Keys)
        {
            Console.WriteLine(item);
        }

        //* Values
        Console.WriteLine("********* Values *********");
        foreach (var item in kullanıcılar.Values)
        {
            Console.WriteLine(item);
        }





















        //* ******************************************* ArrayList ***********************************
        // ArrayList list = new ArrayList();
        // list.Add("Ayse");
        // list.Add(2);
        // list.Add(true);
        // list.Add('A');
        
        //* Verilere Erişim
        // Console.WriteLine(list[1]);
        // foreach (var item in list)
        // {
        //     Console.WriteLine(item);
        // }
        
        //* AddRange
        // Console.WriteLine("***** AddRange *****");
        // string[] renkler = {"Kırmızı", "Mavi", "Turuncu", "Sarı", "Yeşil"};
        // List<int> sayilar = new List<int>(){23, 10, 4, 5, 92, 34};
        
        // list.AddRange(renkler);
        // list.AddRange(sayilar);
        // foreach (var item in list)
        //     Console.WriteLine(item);

        // //* Sort
        // Console.WriteLine("***** Sort *****");
        // list.Sort();    
        // foreach (var item in list)
        //     Console.WriteLine(item);
        
        // //* Binary Search 
        // Console.WriteLine("***** Binary Search *****");
        // Console.WriteLine(list.BinarySearch(10));

        // //* Reverse
        // Console.WriteLine("***** Reverse *****");
        // list.Reverse();
        // foreach (var item in list)
        //     Console.WriteLine(item);

        //* Clear
        // Console.WriteLine("***** Clear *****");
        // list.Clear();
        // foreach (var item in list)
        //     Console.WriteLine(item)

        //* ********************************************* List ******************************************
        // List<int> sayiListesi = new List<int>();
        // sayiListesi.Add(23);
        // sayiListesi.Add(10);
        // sayiListesi.Add(4);
        // sayiListesi.Add(5);
        // sayiListesi.Add(92);
        // sayiListesi.Add(34);
        
        // List<string> renkListesi = new List<string>();
        // renkListesi.Add("Kırmızı");
        // renkListesi.Add("Mavi");
        // renkListesi.Add("Turuncu");
        // renkListesi.Add("Sarı");
        // renkListesi.Add("Yeşil");

        // //* Count
        // Console.WriteLine(sayiListesi.Count);
        // Console.WriteLine(renkListesi.Count);

        // foreach (var sayi in sayiListesi)
        //     Console.WriteLine(sayi);

        // foreach (var renk in renkListesi)
        //     Console.WriteLine(renk);

        // sayiListesi.ForEach(sayi => Console.WriteLine(sayi * 2));
        // renkListesi.ForEach(renk => Console.WriteLine(renk.ToUpper()));

        // //* Eleman Cıkarma
        // sayiListesi.Remove(4);
        // renkListesi.Remove("Yeşil");

        // Console.WriteLine(renkListesi);
        // Console.WriteLine(sayiListesi);

        // sayiListesi.RemoveAt(0);
        // renkListesi.RemoveAt(1);

        // Console.WriteLine(renkListesi);
        // Console.WriteLine(sayiListesi);

        // //* Arama Yapma
        // if(sayiListesi.Contains(10)){
        //     Console.WriteLine("10 Liste Icinde");
        // } else {
        //     Console.WriteLine("10 Liste Icinde Yok");
        // }

        // //* Indexten erişim
        // Console.WriteLine(renkListesi.BinarySearch("Kırmızı"));

        // //* Diziyi Listeye Cevirme
        // string[] hayvanlar = {"Kedi", "Koşk", "Kus"};
        // List<string> hayvanListesi = new List<string>(hayvanlar);

        // //* Listeyi Temizleme
        // hayvanListesi.Clear();
        // Console.WriteLine(hayvanListesi.Count);

    //     List<Kullanıcılar> KullanıcıListesi = new List<Kullanıcılar>();

    //     Kullanıcılar kullanıcı1 = new Kullanıcılar();
    //     kullanıcı1.Isim = "Ayşe";
    //     kullanıcı1.Soyisim = "Kara";
    //     kullanıcı1.Yas = 22;

    //     Kullanıcılar kullanıcı2 = new Kullanıcılar();
    //     kullanıcı2.Isim = "Fatma";
    //     kullanıcı2.Soyisim = "Yılmaz";
    //     kullanıcı2.Yas = 25;

    //     KullanıcıListesi.Add(kullanıcı1);
    //     KullanıcıListesi.Add(kullanıcı2);

    //     List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

    //     yeniListe.Add(new Kullanıcılar(){
    //         Isim = "Deniz",
    //         Soyisim = "Arda",
    //         Yas = 24
    //     });

    //     foreach (var Kullanıcı in KullanıcıListesi){
    //         Console.WriteLine("Kullanıcı Adı: " + Kullanıcı.Isim);
    //         Console.WriteLine("Kullanıcı Soyadı: " + Kullanıcı.Soyisim);
    //         Console.WriteLine("Kullanıcı Yası: " + Kullanıcı.Yas);
    //     }
    //     yeniListe.Clear();
    // }

    // public class Kullanıcılar {
    //     private string isim;
    //     private string soyisim;
    //     private int yas;

    //     public string Isim { get => isim; set => isim = value; }
    //     public string Soyisim { get => soyisim; set => soyisim = value; }
    //     public int Yas { get => yas; set => yas = value; }
    // }



    }
}
