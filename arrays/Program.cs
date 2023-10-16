

string[] renkler = new string[5];
string[] hayvanlar = { "Kedi", "Köpek", "Kus", "Maymun" };
int[] dizi;
dizi = new int[5];

renkler[0] = "Mavi";
dizi[3] = 10;

Console.WriteLine(hayvanlar[1]);
Console.WriteLine(dizi[3]);
Console.WriteLine(renkler[0]);


// Klavyeden girilen n tane sayinin ortalamasini hesaplayan program

Console.Write("\nLūtten olusturmak istediginiz dizinin eleman sayisini giriniz: ");
int diziUzunlugu = int.Parse(Console.ReadLine());
int[] sayiDizisi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lūtten {0}. sayiyi giriniz: ", i + 1);
    sayiDizisi[i] = int.Parse(Console.ReadLine());
}

int toplam = 0;
foreach (var sayi in sayiDizisi)
{
    toplam += sayi;
}
Console.Write("\nOrtalama : " + toplam / diziUzunlugu);
Console.ReadKey();