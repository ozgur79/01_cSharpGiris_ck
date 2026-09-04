# Değerlendirme — ck0060 Tam Sayı Bölmesi

1. `floatSonuc` bir `float` değişken olduğu halde neden sonuç yine 2 çıktı (2,5 değil)?
   > Cevap notu: `x / y` işlemi, `float`'a atanmadan ÖNCE, iki int arasında yapılıyor —
   > sonuç orada 2'ye düşüyor, float'a atama sadece o 2'yi taşıyor.

2. Kendi çözümünde 2,5 sonucunu nasıl elde ettin?
   > Cevap notu: `(double)x / y` (ya da `(double)y`) — iki sayıdan birini bölmeden önce
   > double'a çevirmesi yeterli, öğrenci farklı bir yolla da (örn. her iki değişkeni de
   > baştan double tanımlamak) doğru sonuca ulaşmışsa kabul edilir.

3. `int`, `float`, `double` — bu üçü arasındaki fark ne, tek cümleyle anlat.
   > Cevap notu: `int` küsuratsız tam sayı tutar, `float`/`double` virgüllü (ondalıklı)
   > sayı tutar — ikisinin arasındaki hassasiyet farkına henüz girilmedi, öğrencinin
   > "int tam sayı, diğerleri virgüllü" demesi bu aşamada yeterli.
