// Next(0, 5) ile test edildi: 5 slotluk diziyi doldurmak neredeyse imkansız hale
// geliyor (1000 turda bile sayac 5'e ulaşamadı) — çünkü gerçek bir "0" üretildiğinde
// bu, henüz doldurulmamış slotların varsayılan 0 değeriyle karışıyor ve "zaten var"
// sanılıp reddediliyor; son slotu GERÇEKTEN 0 ile doldurmak neredeyse imkansız
// oluyor. Next(1, 6) kullanmak (orijinal kod) bu tuzağı tamamen ortadan kaldırıyor.
