# Değerlendirme — ck0310

1. maas=1000 girilirse hangi dal çalışır, kesinti oranı ne olur?
   (Özgür için: ilk dal — `maas <= 1000` sınırı 1000'i de kapsıyor, %10 kesinti uygulanır.)

2. maas=3500 ile maas=3501 arasında kesinti oranı neden aniden değişiyor (yumuşak bir
   geçiş yok)?
   (Özgür için: else if zinciri kesin sınırlarla çalışır, 3500'e kadar %15, 3500'ün
   üzerinde direkt %20 — aradaki geçiş kademeli değil, ani bir sınır.)
