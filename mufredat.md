# Müfredat

Ders listesi ve kara kutu takip tablosu. Her onaylanan derste bu dosya güncellenir.

## Ders listesi

| ders | konu | tür | zincir (dil) | zincir (arayüz) | kaynak | durum |
|------|------|-----|---------------|-------------------|--------|-------|
| ck0010_merhabaDunya | Console.Write / Console.WriteLine, satır sonu farkı | Console | çıktı (giriş öncesi) | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 1) | onaylandı |
| ck0020_adinizNedir | string değişken, Console.ReadLine ile klavyeden yazı okuma, + ile birleştirme | Console | değişken (string) + girdi | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 2) | onaylandı |
| ck0030_ikiSayiToplam | int değişken, Convert.ToInt32 ile sayıya çevirme, + ile sayısal toplama | Console | değişken (int) + operatör (+) | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 3, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0040_sayininIkiKati | * ile çarpma | Console | operatör (*) | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 4, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0050_sayininKaresi | bir sayıyı kendisiyle çarpma (kare alma) | Console | operatör (*) pekiştirme | Console | arsiv/01cSharpÇekirdekKodlar.txt (parça 5) | onaylandı |
| ck0060_tamSayiBolmesi | int bölmesinin küsuratı atması, float/double tipleri | Console | operatör (/) + veri tipi (float, double) | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 6) | onaylandı |
| ck0070_metotVeSinif | "metot" ve "sınıf" terimleri, Console.WriteLine örneğiyle (IntelliSense) | Console | terim (metot, sınıf) | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 7) | onaylandı |
| ck0080_stringToplamaTuzagi | string + string'in birleştirme yaptığı, sayısal toplama olmadığı | Console | operatör (+) string vs sayı, pekiştirme | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 8, kısım b) | onaylandı |

## Kara kutu takip tablosu

Hangi yapı hangi derste ilk göründü, nerede tam açılacak. "Merak Köşesi günlüğü" —
hangi derste o kutuya dair ne söylendi, rotasyon kaybolmasın diye tutulur. Rotasyon
sırası: `using` → `namespace` → `class Program` → `static Main` → `Console.ReadKey` →
(başa dön). ck0010 kendi Merak Köşesi'ni kullanmaz (sadece çerçeve notunu taşır),
rotasyon ck0020'den başlar. ck0070 kendi yeni fikri (metot/sınıf terimleri) ağır
olduğu için Merak Köşesi'ni atlar — rotasyon kaymaz, sıradaki kutu ck0080'e geçer.

| yapı | ilk göründüğü ders | açılacağı yer | Merak Köşesi günlüğü | not |
|------|----------------------|-------------------|----------------------|-----|
| `using System;` / `using System.Collections.Generic;` / `using System.Linq;` / `using System.Text;` / `using System.Threading.Tasks;` | ck0010 | ünite 03 (nesne yönelimli programlama) | ck0020: hazır kütüphaneleri projene dahil eder; ck0080: neden 5 ayrı satır var, her biri ayrı bir "araç kutusu" (2. tur, yeni açı) | [iskelet-bağımlı] — VS'in her yeni Console projesine otomatik eklediği satırlar |
| `namespace <proje adın>` | ck0010 | ünite 03 (nesne yönelimli programlama) | ck0030: kodları isim altında gruplayan "klasör" gibidir, proje adından VS'in ürettiği isim | [iskelet-bağımlı] — OOP dersine kadar açılmayacak |
| `class Program` | ck0010 | ünite 03 (nesne yönelimli programlama) | ck0040: namespace'in içindeki kutulardan biri, yazdığın her satır bu kutuda durdu | [iskelet-bağımlı] — OOP dersine kadar açılmayacak |
| `static void Main(string[] args)` | ck0010 | ünite 03 (nesne yönelimli programlama) | ck0050: class Program'ın içinde, programın başladığı satır | [iskelet-bağımlı] — OOP dersine kadar açılmayacak |
| `Console.ReadKey();` | ck0010 | ileride ayrı bir derste (konsol penceresi) | ck0060: Main'den sonraki son satır, o olmasa pencere anında kapanır | rotasyona ck0060'ta katıldı — OOP'a bağlı değil, ayrı konu |
| `Console.WriteLine`/`Write` (metot), `Console` (sınıf) terimleri | ck0010 | ck0070 (üretildi) | ck0070: void ile başlayan her şey metot, Console bir sınıf | rotasyon dışı — VS iskeletinden bağımsız, Console zaten var olan hazır bir sınıf |
