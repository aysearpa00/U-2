# **Takım İsmi**

Bash Squad

# Ürün İle İlgili Bilgiler

## Takım Elemanları

- Salim Berk Uzun: Project Owner
- Haktan Serin: Developer
- Adnan Enes Parlar: Scrum Master
- Ayşe Arpa: Developer
- Begüm Akbaş: Developer

## Ürün İsmi

--Fun Fiesta--

## Ürün Açıklaması

- Oyunumuz tek ve çok oyunculu oynanbilen bir party oyunur. Kısa oyunlar ve oyun içi görevler ile eğlenceli ve sürükleyici bir deneyim sunmak amaçlanmıştır.

## Ürün Özellikleri

- Party oyunu
- Multiplayer ve single player modu var
- Kısa oyunlar ile sürükleyicilik sağlanır
- Skor tablosu vardır

## Hedef Kitle

- Retro oyun severler
- Kalabalık arkadaş grupları
- Çocuklar ve çocuk ruhlular

## Product Backlog URL

[Trello Backlog Board](https://trello.com/b/597XY6kT/u-2)

---

# Sprint 1

- **Backlog düzeni **: Backlogumuz oyunu geliştime aşamasında geçmeyi planladığımız alt başlıklara göre düzenlenmiştir. Bunlar ilerleme durumumuz ile pararlel olmakla birlikte şu an fikirler/kod/tasarım olarak üçe ayrılmıştır. Bu süreç içerisinde ihtiyacımız olan fikirler beyin fırtınası yapmak amacıyla sunum halinde düzenlenmiştir.
- Oyun geliştirme sürecimizin temel iki bileşeni olan kodlama ve tasarım süreçleri iki ayrı segmentte kendi içerisinde ilerletilmiştir.

- **Daily Scrum**: Daily Scrum toplantıları discord ve whatsapp üzerinden sesli ve/veya yazılı olarak gerçekleştirilmiştir. Projenin ilerleyişine dair bireysel çalışmalar gözden geçirilip not edilmiştir ve birleştirilmiştir.

- **Sprint board update**: Sprint board screenshotları:
![Ekran görüntüsü 2024-07-07 232459](https://github.com/aysearpa00/U-2/assets/159146551/8ad1df71-ac31-4083-a23c-610b5b8929e3)
![Ekran görüntüsü 2024-07-07 232445](https://github.com/aysearpa00/U-2/assets/159146551/d753a868-e606-4aa0-a126-a842de7da965)
![Ekran görüntüsü 2024-07-07 232517](https://github.com/aysearpa00/U-2/assets/159146551/0df9a51f-bedd-44fe-86d9-e95f01707c01)

- **Ürün Durumu**:
- Ürünün konusu ve türü belirlendikten sonra oyun mekaniği tartışıldı.
- Multi player ve single player oynanabilme seçenekleri eklenmesi planlandığı için oyunun mekaniği hakkında ilerleme kat edildi.
- Oyun içerisinde kullanılabilecek assetler toplandı.
- Oyun görselleri henüz paylaşılamaz.

- **Sprint Review**: 
Alınan kararlar doğrultusunda, oyunumuzda Photon PUN eklentisini kullanmaya karar verdik. İlk olarak bir lobi sistemi oluşturduk. Oyunumuzda hem tek oyunculu (single player) hem de çok oyunculu (multi player) seçenekler mevcuttur ve üçüncü şahıs bakış açısıyla oynanır. Oyun kurucu, bir oda kurar ve diğer oyuncular bu odaya katılır. Oyuncu sayısı iki ile sınırlandırılmıştır. Bu eklenti ile sunucu ve istemci arasında oyuncuların hareketlerini senkronize ettik. Şu anda oyuncular birbirlerine ateş ederek birbirlerinin can seviyesini düşürmektedirler. Can seviyesi belirli bir seviyenin altına düştüğünde, oyuncu oyundan çıkarılmaktadır.

- **Sprint Retrospective:**
  - Takım içi iletişim ve senkronizasyon daha etkin olabilirdi. Bir sonraki sprint başlangıcından itibaren iletişim kanallarının etkili şekilde kullanılması hedeflendi.
  - Ekibimizde multiplayer geliştirme deneyimi olan birinin bulunmaması nedeniyle, öncesinde daha detaylı bir kaynak araştırması yapılabilirdi.
  - Oyunun fonksiyonları ve oynanışı üzerinde yoğun şekilde çalışılmış ve fikir alışverişi yapılmış olsa da, oyun hikayesine de daha fazla önem verilebilirdi. Bir sonraki adımda oyun hikayesi üzerinde geliştirmeler yapılabilir.
