# Değerlendirme — ck0715

1. Array.Resize çağrısında neden dizi değil ref dizi yazılıyor?
   (Özgür için: Array.Resize dizinin KENDİSİNİ (boyutunu) değiştiriyor; ref, metoda
   "bu değişkeni doğrudan güncelle" demenin yolu — normal bir parametre olsaydı
   metot sadece dizinin bir kopyasını büyütür, orijinal değişmezdi.)

2. Array.Resize(ref dizi, 2) ile küçültülürse "veli" ne olur?
   (Özgür için: dizi 2 elemana düşer, sondaki "veli" tamamen kaybolur — Resize
   fazlalık elemanları saklamaz, gerçekten atar.)
