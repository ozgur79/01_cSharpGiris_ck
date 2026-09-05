# Müfredat

Ders listesi ve kara kutu takip tablosu. Her onaylanan derste bu dosya güncellenir.
Bu dosya şimdilik yalnızca Console (ünite 00-04) derslerini listeler. WinForms dersleri
(ünite 05-09) için üretim planı `winforms-plan.md`'de ders ders yazılı; WinForms
üretimi fiilen başlayınca satırlar bu dosyaya da (aynı ders listesi + kara kutu
tablosu formatında) girecek.

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
| ck0090_tekKarakterOkuma | Console.Read() ile tek karakter okuma, int (ASCII kod) döndürmesi | Console | metot çeşitliliği (Read vs ReadLine) | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 9) | onaylandı |
| ck0100_veriTipleriTanisma | byte, bool, char tiplerinin tanıtımı (int/double/string recap ile bir arada) | Console | veri tipi çeşitliliği | Console | arsiv/02cSharpÇekirdekKodlar.txt (madde 10) | onaylandı |
| ck0110_dortgenCevreAlan | parantez ile işlem sırasını belirleme, aynı girdilerden birden fazla sonuç hesaplama | Console | operatör (parantez/öncelik) | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 11, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0120_ucSayiOrtalama | üç sayının ortalaması, parantez zorunluluğu + int bölmesi küsuratı pekiştirme | Console | operatör (parantez) pekiştirme | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 12, `ToInt16`→`ToInt32` düzeltildi) | onaylandı |
| ck0130_kareVeKup | küp alma (3 katlı çarpma), aynı programda iki farklı hesap yapma | Console | operatör (*) pekiştirme | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 13, `ToInt16`→`ToInt32` düzeltildi, giriş etiketleri netleştirildi) | onaylandı |
| ck0140_ilkKararYapisi | if/else ile karar yapısına giriş, == ile eşitlik karşılaştırması, string büyük/küçük harf duyarlılığı | Console | karar yapısı (if/else) — zincire yeni halka | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 14) | onaylandı |
| ck0150_cokDalliKarar | else if ile çok dallı karar, >,< sayısal karşılaştırma, çok satırlı blokta süslü parantez zorunluluğu | Console | karar yapısı (if/else if/else) pekiştirme | Console | arsiv/03cSharpÇekirdekKodlar.txt (madde 15) | onaylandı |

## Kara kutu takip tablosu

Hangi yapı hangi derste ilk göründü, nerede tam açılacak. "Merak Köşesi günlüğü" —
hangi derste o kutuya dair ne söylendi, rotasyon kaybolmasın diye tutulur. Rotasyon
sırası: `using` → `namespace` → `class Program` → `static Main` → `Console.ReadKey` →
(başa dön). ck0010 kendi Merak Köşesi'ni kullanmaz (sadece çerçeve notunu taşır),
rotasyon ck0020'den başlar. ck0070 kendi yeni fikri (metot/sınıf terimleri) ağır
olduğu için Merak Köşesi'ni atlar — rotasyon kaymaz, sıradaki kutu ck0080'e geçer.
ck0100 de kendi yeni fikri (aynı derste byte/bool/char — üç yeni tip) ağır olduğu
için Merak Köşesi'ni atlar; rotasyon kaymaz, sıradaki kutu (`class Program`, 2. tur)
bir sonraki derse geçer. ck0110=`class Program` (2. tur), ck0120=`static Main` (2. tur),
ck0130=`Console.ReadKey` (2. tur) — 2. tur tamamlandı. ck0140 ve ck0150 (if/else girişi
ve çok dallı karar — karar yapısı zincirine yeni halka) yük freniyle Merak Köşesi'ni
atlıyor; rotasyon kaymıyor, sıradaki kutu `using` (3. ve **son** tur, sonra emekli)
bir sonraki yüksüz derste kullanılacak.

**Açılış yeri ünite 07 (2026-09-05, Özgür onayladı — Karar 16).** Beş iskelet kutusu
(`using`, `namespace`, `class Program`, `static Main`, `Console.ReadKey`) WinForms
ünite 07'de (nesne tabanlı programlama girişi) kapanacak — ayrıntı `winforms-plan.md`
"Kara kutu takvimi". Eski "ünite 03" ibaresi bu yüzden "ünite 07" olarak düzeltildi.

**Rotasyon freni (Karar 17).** Bir kutu **3 tur** Merak Köşesi'ne konu olduysa
`emekli` sayılır, ünite 07'ye kadar bir daha yazılmaz — "tur/emekli" sütunu bunu
izler. Köşenin asıl işi dersin **kendi yeni** kara kutusu; iskelet rotasyonu yalnız
kendi yeni kutusu olmayan derslerde yedek olarak devreye girer.

| yapı | ilk göründüğü ders | açılacağı yer | tur / emekli | Merak Köşesi günlüğü | not |
|------|----------------------|-------------------|----------------|----------------------|-----|
| `using System;` / `using System.Collections.Generic;` / `using System.Linq;` / `using System.Text;` / `using System.Threading.Tasks;` | ck0010 | ünite 07 (nesne tabanlı programlama) | 2 tur (emekli değil) | ck0020: hazır kütüphaneleri projene dahil eder; ck0080: neden 5 ayrı satır var, her biri ayrı bir "araç kutusu" (2. tur, yeni açı) | [iskelet-bağımlı] — VS'in her yeni Console projesine otomatik eklediği satırlar |
| `namespace <proje adın>` | ck0010 | ünite 07 (nesne tabanlı programlama) | 2 tur (emekli değil) | ck0030: kodları isim altında gruplayan "klasör" gibidir, proje adından VS'in ürettiği isim; ck0090: her yeni projede namespace'in neden değiştiği (2. tur, yeni açı) | [iskelet-bağımlı] — ünite 07'ye kadar açılmayacak |
| `class Program` | ck0010 | ünite 07 (nesne tabanlı programlama) | 2 tur (emekli değil) | ck0040: namespace'in içindeki kutulardan biri, yazdığın her satır bu kutuda durdu; ck0110: adı hep aynı kalır (VS otomatik verir), namespace proje adına göre değişir (2. tur, yeni açı) | [iskelet-bağımlı] — ünite 07'ye kadar açılmayacak |
| `static void Main(string[] args)` | ck0010 | ünite 07 (nesne tabanlı programlama) | 2 tur (emekli değil) | ck0050: class Program'ın içinde, programın başladığı satır; ck0120: başladığı satırdan itibaren kod yukarıdan aşağı sırayla çalışır (2. tur, yeni açı) | [iskelet-bağımlı] — ünite 07'ye kadar açılmayacak |
| `Console.ReadKey();` | ck0010 | ünite 07 (nesne tabanlı programlama) | 2 tur (emekli değil) | ck0060: Main'den sonraki son satır, o olmasa pencere anında kapanır; ck0130: iki sonuç hesaplanan derste neden en sonda durması gerektiği (2. tur, yeni açı) | rotasyona ck0060'ta katıldı, diğer iskelet kutularıyla birlikte ünite 07'de kapanacak |
| `Console.WriteLine`/`Write` (metot), `Console` (sınıf) terimleri | ck0010 | ck0070 (üretildi) | rotasyon dışı | ck0070: void ile başlayan her şey metot, Console bir sınıf | rotasyon dışı — VS iskeletinden bağımsız, Console zaten var olan hazır bir sınıf |
