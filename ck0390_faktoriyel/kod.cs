// ck0390 — Faktöriyel: çarpımsal biriktirici + i++
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0350'deki biriktirici toplama (+=) yapıyordu, burada çarpma (*) ile
//                  "çarpımsal biriktirici" kuruluyor. i++ ilk kez burada — i = i + 1 ile
//                  aynı anlama gelir, döngü sayacını 1 artırır.

// --- KAVRAM ---
int sayi, sonuc = 1;
Console.Write("Faktöriyeli alınacak sayıyı girin : ");
sayi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= sayi; i++) // i++ demek i=i+1 demektir
{
    sonuc = sonuc * i;
}
Console.Write(sayi + "! = " + sonuc);
Console.ReadKey();

// --- SEN YAP ---
// sayi=5 ile çalıştır, sonuc=120 çıkmalı (1*1*2*3*4*5). Her turda sonuc'un nasıl
// büyüdüğünü elle takip et: 1. turda sonuc kaç, 2. turda kaç?
