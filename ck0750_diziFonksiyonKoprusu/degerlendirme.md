# Değerlendirme — ck0750

1. strDizi ve elemanSayac neden Main()'in İÇİNDE değil, class'ın içinde tanımlı?
   (Özgür için: elemanEkle ve listele metotlarının İKİSİ de bu iki değişkene erişmesi
   gerekiyor; Main() içinde tanımlansaydı diğer metotlar onları göremezdi — class
   seviyesinde tanımlamak, aynı kutudaki tüm metotların paylaşmasını sağlar.)

2. elemanEkle her çağrıldığında elemanSayac'ı neden artırıyor?
   (Özgür için: strDizi'de bir sonraki BOŞ yerin nerede olduğunu takip etmek için —
   elemanSayac olmasa her elemanEkle çağrısı hep strDizi[0]'ın üzerine yazardı.)
