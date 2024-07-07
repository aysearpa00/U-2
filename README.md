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

- **Sprint içinde tamamlanması tahmin edilen puan**: 100 Puan

- **Puan tamamlama mantığı**: Toplamda proje boyunca tamamlanması gereken 380 puanlık backlog bulunmaktadır. 4 sprint'e bölündüğünde ilk sprint'in en azından 100 ile başlaması gerektiğine karar verildi.

- **Backlog düzeni **: Backlogumuz oyunu geliştime aşamasında geçmeyi planladığımız alt başlıklara göre düzenlenmiştir. Bunlar ilerleme durumumuz ile pararlel olmakla birlikte şu an fikirler/kod/tasarım olarak üçe ayrılmıştır. Bu süreç içerisinde ihtiyacımız olan fikirler beyin fırtınası yapmak amacıyla sunum halinde düzenlenmiştir.
- Oyun geliştirme sürecimizin temel iki bileşeni olan kodlama ve tasarım süreçleri iki ayrı segmentte kendi içerisinde ilerletilmiştir.

- **Daily Scrum**: Daily Scrum toplantıları discord ve whatsapp üzerinden sesli ve/veya yazılı olarak gerçekleştirilmiştir. Projenin ilerleyişine dair bireysel çalışmalar gözden geçirilip not edilmiştir ve birleştirilmiştir.

- **Sprint board update**: Sprint board screenshotları: 
![Backlog 1](https://raw.githubusercontent.com/OyunveUygulamaAkademisi/BootcampScrumTemplate/main/ProjectManagement/Sprint1Documents/backlog1.png) 
![Backlog 2](https://raw.githubusercontent.com/OyunveUygulamaAkademisi/BootcampScrumTemplate/main/ProjectManagement/Sprint1Documents/backlog2.png) 
![Backlog 3](https://raw.githubusercontent.com/OyunveUygulamaAkademisi/BootcampScrumTemplate/main/ProjectManagement/Sprint1Documents/backlog3.png)

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
