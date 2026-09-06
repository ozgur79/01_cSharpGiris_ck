// ck0200 — Cinsiyet okuma: Convert.ToChar ile klavyeden tek karakter
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: Convert.ToChar ile klavyeden okunan yazıyı char'a çevirmek (ck0100'de
//                  char'ı tanımıştık, klavyeden okumasını ilk kez burada görüyoruz).

// --- KAVRAM ---
char cinsiyet;
Console.Write("Cinsiyetinizi Girin (E/K) : ");
cinsiyet = Convert.ToChar(Console.ReadLine()); // ReadLine() bir string döner, ToChar tek karaktere çevirir
if (cinsiyet == 'e' || cinsiyet == 'E')
    Console.WriteLine("Erkek");
else
    Console.WriteLine("Kadın");
Console.ReadKey();

// --- SEN YAP ---
// "e", "E" ve "k" ile üç kez çalıştır. Sonra iki karakter birden yazıp ("ek" gibi) ne
// olduğunu gözlemle — hata mesajını oku, ne diyor?
