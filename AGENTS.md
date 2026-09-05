# 01_cSharpGiris_ck — Console hattı

Kimlik, sert sınırlar, ders üretim döngüsü, isimlendirme ve **kara kutu doktrini** üst
klasörde: `D:\Atolye\cSharp\CLAUDE.md`. Burada tekrar edilmez. Bu dosya sadece bu projenin
kendi kapsamını yazar.

## Kapsam

**ck0000-ck0499, ünite 00-04, yalnız Console (terminal).** WinForms ve nesne tabanlı
programlama bu repo'ya girmez — onlar `02_cSharpForm_ck`'de (ön koşulu bu projeyi
tamamlamış olmak).

Kaynak arşiv: `..\arsiv\` — Özgür tek tek parça verir, ck sırayla ders üretir.

## Console dersi: tek dosya, `kod.cs`

Ders klasörüne tek `kod.cs` girer — boş bir Console projesinin `Main()`'ine yapıştırılacak
parçadır, tam dosya değil. **Kendi ortamında (`dotnet` CLI, geçici klasörde) gerçekten
çalıştırılmadan "bitti" sayılmaz** — örnek girdi ver, çıktıyı gör. O geçici iskelet asla
commit'e girmez, sadece `kod.cs` girer.

Dosya dört parçadan oluşur: **başlık** · **KAVRAM** · **SEN YAP** · **MERAK KÖŞESİ**.

```csharp
// ck0040 — Sayının iki katı
// NASIL: Yeni bir Console Application aç, aşağıdakini Main() içine yapıştır.
// Ne öğreneceğiz: * ile çarpma yapmak (bir önceki derste + ile toplama görmüştük)
// Not: Üstteki using/namespace/class/Main satırları VS'in hazır iskeleti.
//      Şimdilik olduğu gibi bırak, hepsini ünite 07'de tek tek açacağız.

// --- KAVRAM ---
// (kısa, tek satırlık yorumlarla; uzun paragraf yok — sadece Main() içine gidecek kod)

// --- SEN YAP ---
// (kısa, net; cevap YOK — cevap cozumler/ckXXXX_isim/ altında)

// --- MERAK KÖŞESİ ---
// class Program nedir?
// Yazdığın her satır bir "class"ın içinde durmak zorunda. class, birbirine ait
// kodların yaşadığı kutudur. Program, VS'in bu kutuya verdiği ad — "Merhaba"
// yazan o tek satır bile Program kutusunun içindedir.
// Kutunun kendisini ünite 07'de (nesne tabanlı programlama) açacağız.
```

**Çerçeve notu (2 satır, her Console dersinde aynı):** `Not:` satırı sabittir, uzamaz.
Dersin **kendine ait yeni** bir kara kutusu varsa (iskeletten gelmeyen, o derste ilk kez
görülen bir yapı) çerçeve notuna tek satır eklenir, açıklaması yine Merak Köşesi'ne gider.

**Console'un iskelet kutuları ve rotasyon sırası:** `using` → `namespace` → `class Program`
→ `static Main` → `Console.ReadKey` → başa dön. Üç tur sonra kutu emekliye ayrılır (üst
klasördeki doktrine bak); hepsi ünite 07'de, yani `02_cSharpForm_ck`'de açılır.

**Konu/sıra:** dil zinciri değişken → operatör → karar yapısı → döngü → dizi → fonksiyon.
OOP bu repo'da yok.

## Klasörler

Ortak dosya setine ek olarak burada `Test-Gunlugu.md` kullanılmaz (WinForms dersi yok).
`ornek/` klasörü de bu repo'da tutulmaz — WinForms numunesi 02'de.
