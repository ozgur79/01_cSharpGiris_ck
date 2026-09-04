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

## Kara kutu takip tablosu

Hangi yapı hangi derste ilk göründü, hangi derste açılacak (öğretilecek). "Ön izleme
günlüğü" — hangi derste o kutuya dair ne söylendi, rotasyon kaybolmasın diye tutulur.
Rotasyon sırası: `using` → `namespace` → `class Program` → `static Main` → (başa dön).

| yapı | ilk göründüğü ders | açılacağı ders | ön izleme günlüğü | not |
|------|----------------------|-------------------|----------------------|-----|
| `using System;` / `using System.Collections.Generic;` / `using System.Linq;` / `using System.Text;` / `using System.Threading.Tasks;` | ck0010 | ckXXXX | ck0020: "hazır kütüphaneleri projene dahil eder"; ck0060: "her using satırı ayrı bir araç kutusu" | [iskelet-bağımlı] — VS2013'ün her yeni Console projesine otomatik eklediği satırlar |
| `namespace <proje adın>` | ck0010 | ckXXXX | ck0030: "kodları isim altında gruplayan 'klasör' gibidir, çakışmayı önler" | [iskelet-bağımlı] — VS'in proje adına göre otomatik oluşturduğu ad, OOP dersine kadar açılmayacak |
| `class Program` | ck0010 | ckXXXX | ck0040: "her kod bir class içinde yaşar, Program ana sınıf" | [iskelet-bağımlı] — OOP dersine kadar açılmayacak |
| `static void Main(string[] args)` | ck0010 | ckXXXX | ck0050: "programın başladığı yer, 'Başlat'a basınca çalışan ilk satır" (pekiştirme dersi olduğu için daha ayrıntılı) | [iskelet-bağımlı] — OOP dersine kadar açılmayacak |
| `Console.ReadKey();` | ck0010 | ckXXXX | — (rotasyon dışı, ayrı ele alınıyor) | konsolun neden açık kaldığını o zaman göreceğiz |
