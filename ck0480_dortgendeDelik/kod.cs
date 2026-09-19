// ck0480 — Dikdörtgende tek bir yeri boş bırakma (satır + sütun birlikte)
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: ck0470 satıra, ck0475 sütuna bakıyordu; burada && ile ikisi birden
//                  aranıyor — sadece belirli satır VE belirli sütun kesiştiğinde tek bir
//                  yerde delik açılıyor. i++ satırı, o konumda satırın uzunluğunun
//                  kaymaması için sayacı bir adım fazladan ilerletiyor.

// --- KAVRAM ---
for (int k = 0; k <= 10; k++)
{
    for (int i = 0; i < 5; i++)
    {
        if (k == 5 && i == 2)
        {
            Console.Write(" ");
            i++;
        }
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.ReadKey();

// --- SEN YAP ---
// k==5 && i==2 satırını çalıştırmadan önce hangi satırda, hangi sütunda delik olacağını
// tahmin et. Sonra k==3 && i==1 yap, tahminini yeni koşulla tekrar dene.
// Sonra her satırın son yıldızını + yap (ipucu: i==4 kontrolü ekle, delik koşuluyla karışmasın).
