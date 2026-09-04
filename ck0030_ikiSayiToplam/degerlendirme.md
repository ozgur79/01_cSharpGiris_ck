# Değerlendirme — ck0030 İki Sayının Toplamı

1. `Convert.ToInt32(Console.ReadLine())` satırı iki işlemi art arda yapıyor, hangileri?
   > Cevap notu: Önce `Console.ReadLine()` klavyeden yazı okur, sonra `Convert.ToInt32`
   > o yazıyı sayıya (int) çevirir. İki ayrı adım olduğunu görmesi yeterli.

2. `int s1, s2, toplam;` ile `string isim;` (bir önceki ders) arasındaki fark ne?
   > Cevap notu: İkisi de değişken tanımlıyor ama farklı tip — biri sayı (int) tutar,
   > diğeri yazı (string). `int` içine yazı, `string` içine çıplak sayı konamaz.

3. Bu derste `+` ile bir önceki derste (`"Merhaba " + isim`) kullanılan `+` aynı şeyi mi
   yapıyor?
   > Cevap notu: Hayır — burada iki sayıyı toplar, orada iki yazıyı birleştirir. Aynı
   > sembolün duruma göre farklı iş yaptığını fark etmesi yeterli.
