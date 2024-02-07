//1. Soru
//Console.Write("Girmek istediğiniz Sayı Adetini Giriniz: ");

//int sayiAdeti = int.Parse(Console.ReadLine());
//int[] sayiDizisi = new int[sayiAdeti];
//for (int i = 0; i < sayiAdeti; i++)
//{
//    Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
//    sayiDizisi[i] = int.Parse(Console.ReadLine());
//}
//Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
//int bolonebilenSayi = 0;
//for (int i = 0; i < sayiAdeti; i++)
//{
//    if (sayiDizisi[i] % 2 == 0)
//    {
//        bolonebilenSayi++;
//        Console.Write(sayiDizisi[i] + " ");
//    }
//}

//2.Soru
Console.Write("Hangi Sayının Bölünmesini İstersiniz: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
int sayiAdet = int.Parse(Console.ReadLine());
int[] sayiDizis = new int[sayiAdet];
for (int i = 0; i < sayiAdet; i++)
{
    Console.Write("Lütfen {0}. Sayısı Giriniz: ", i + 1);
    sayiDizis[i] = int.Parse(Console.ReadLine());
}

Console.Write("Girmiş Olduğunuz Çift Sayılar: ");
int bolonebilenSay = 0;
for (int i = 0; i < sayiAdet; i++)
{
    if (sayiDizis[i] % m == 0 || sayiDizis[i] == m)
    {
        bolonebilenSay++;
        Console.Write(sayiDizis[i] + " ");
    }
}

//3. Soru
Console.Write("Kaç Adet Kelime Girmek İstersiniz: ");
int sayiAdeti = int.Parse(Console.ReadLine());
String[] sayiDizisi = new String[sayiAdeti];
for (int i = 0; i < sayiAdeti; i++)
{
    Console.Write("Lütfen {0}. Kelimeyi Giriniz: ", i + 1);
    sayiDizisi[i] = (Console.ReadLine());
}


Array.Reverse(sayiDizisi);
Console.Write("Girmiş Olduğunuz Kelimeler: ");
for (int i = 0; i < sayiAdeti; i++)
{
    Console.Write(sayiDizisi[i] + " ");

}

//4. Soru
Console.Write("Bir Cümle Yazınız: ");
String sayiDizi = Console.ReadLine();

int harf = sayiDizisi.Length;
string[] bos = sayiDizi.Split(' ');
int bosluksuzharf = harf - (bos.Length - 1);
Console.WriteLine("Toplam Kelime: " + bos.Length + " Toplam Harf: " + bosluksuzharf);