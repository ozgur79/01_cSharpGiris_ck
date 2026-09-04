# Notlar

Serbest not alanı.

## 2026-09-04 — Kurulum

- Ortam: Windows 11, öğrenci lab'ı Windows 8 + VS2013 (bkz. CLAUDE.md "Teslim modeli").
- Bu makinede `dotnet` SDK yok, sadece 10.0.5 runtime var. ck'nin kendi doğrulaması için
  ileride SDK kurulumu gerekebilir (bkz. backlog.md).
- `D:\Atolye\cSharp\arsiv\` klasöründe tek dosya var: `01cSharpÇekirdekKodlar.txt`
  (Türkçe karakterli dosya adı — kaynak dosya, repo'ya kopyalanmayacak, sadece referans).
  İçeriği bu oturumda incelenmedi (Faz 0 kapsamı dışı).

## 2026-09-04 — Faz 1+2, ilk tur

- `dotnet` SDK 10.0.400 winget ile kuruldu (`Microsoft.DotNet.SDK.10`), ck kendi
  doğrulamasını yapabiliyor artık.
- `arsiv/01cSharpÇekirdekKodlar.txt` tek dosya ama 5 ayrı numaralı kod parçası içeriyor
  (1: yazdırma, 2: string değişken+girdi, 3: iki sayı toplamı, 4: iki katı, 5: kare).
  "Ders başına tek yeni fikir" kuralı gereği bunları tek derste birleştirmedim — parça 1'i
  ck0010 yaptım, 2-5 sıradaki turlarda ayrı ders olacak.
- ck0010 doğrulaması: `Console.ReadKey()` headless (bu ortamda, TTY'siz) çalıştırılamıyor —
  "console input redirected" hatası veriyor. Bunu geçici olarak yorum satırına alıp
  Write/WriteLine çıktısını (satır sonu farkı) gerçek `dotnet run` ile doğruladım; ReadKey
  ayrıca derlendi (build hatasız), sadece interaktif çalıştırma bu ortamda mümkün değil.
  İleriki Console derslerinde ReadKey/ReadLine içeren kod için aynı yöntem geçerli.
