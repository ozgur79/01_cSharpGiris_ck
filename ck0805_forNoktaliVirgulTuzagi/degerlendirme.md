# Değerlendirme — ck0805

1. Çıktı neden tek bir sayı (11), 7-8-9-10 değil?
   (Özgür için: for(...); satırının sonundaki `;` döngünün gövdesini BOŞ yapar —
   döngü kendi başına 4 kez döner ama içinde hiçbir kod çalışmaz, sadece sayac
   11'e ulaşana kadar sayar. WriteLine artık döngünün dışında, tek başına duran
   bir satırdır; döngü bittikten SONRA bir kez çalışır.)

2. Girinti (kod satırının içeri kaydırılmış olması) derleyiciyi de kandırır mı?
   (Özgür için: hayır — girinti sadece İNSANLARIN gözünü kandırır, C# derleyicisi
   girintiye hiç bakmaz, sadece `{ }` ve `;` gibi işaretlere bakar.)
