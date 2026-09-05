# Değerlendirme — ck0150

1. `else if` ne zaman çalışır?
   (Özgür için: kendinden önceki `if` koşulu yanlış (false) çıktığında sıradaki koşul
   sınanır — koşullar sırayla, yukarıdan aşağı kontrol edilir.)

2. Bir if bloğunda süslü parantez `{ }` ne zaman zorunludur?
   (Özgür için: if'in altında birden fazla satır çalışacaksa zorunludur; tek satır varsa
   C# parantezsiz de kabul eder (ck0140'ta gördüğümüz gibi), ama birden fazla satırda
   parantezsiz sadece ilk satır if'e bağlı kalır, geri kalanı her zaman çalışır.)

3. s1=5, s2=5 girilirse hangi WriteLine çalışır?
   (Özgür için: "Sayılar birbirine eşit." — hem `s1 > s2` hem `s1 < s2` yanlış olduğu için
   sıra en sondaki else'e gelir.)
