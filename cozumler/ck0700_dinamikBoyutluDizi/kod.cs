// sayilar.Length ile boyut aynı sayıyı verir çünkü dizi zaten new int[boyut] ile
// kuruldu — .Length her zaman dizinin GERÇEK eleman sayısını okur, boyut ise sadece
// o anki bir değişkendi. İkisini karıştırmak fark yaratmaz ama .Length kullanmak
// dizinin gerçek boyutuyla HER ZAMAN tutarlı kalır (boyut değişkeni yanlışlıkla
// başka bir değere atansa bile .Length şaşmaz).
