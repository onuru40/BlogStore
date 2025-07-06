BlogStore 📝
BlogStore, ASP.NET Core MVC ile geliştirilen, kullanıcıların makaleler oluşturup okuyabildiği, yorum yapabildiği, yazarlara özel profillerin bulunduğu, yönetici paneli ile içeriklerin kolayca takip edilebildiği çok katmanlı bir blog uygulamasıdır.

🚀 Proje Özellikleri
✅ Kullanıcı girişi ve kaydı (ASP.NET Core Identity ile)
✅ Makale ekleme, silme, güncelleme ve detaylı görüntüleme
✅ Makalelere kategori atama ve kategori bazlı listeleme
✅ Kullanıcı yorumları (AJAX + ViewComponent destekli)
✅ SweetAlert2 ile interaktif bildirim sistemi
✅ HuggingFace ToxicBERT ile toksik yorum kontrolü
✅ HuggingFace çeviri API ile yorum çevirisi (TR-EN)
✅ Gelişmiş yönetici paneli: İstatistikler, içerik ve yorum kontrolü
✅ Responsive tasarım (mobil ve tablet uyumu)
✅ Kullanıcı profili düzenleme ve görsel güncelleme
✅ ViewComponent, jQuery AJAX, Partial View yapıları ile modern yaklaşım
🛠️ Kullanılan Teknolojiler
Katman / Katkı	Teknolojiler / Kütüphaneler
Backend (Sunucu)	ASP.NET Core MVC 6.0, Entity Framework Core
Frontend (Arayüz)	Razor View Engine, HTML, CSS, Bootstrap 5, jQuery
Veritabanı	Microsoft SQL Server
Güvenlik	ASP.NET Core Identity
API / NLP Servisleri	Hugging Face (ToxicBERT, Çeviri API)
Bildirim Sistemi	SweetAlert2
Grafik & Dashboard	Chart.js (kategori analizleri için)
📁 Proje Yapısı
Proje, katmanlı mimari (Layered Architecture) yapısı ile geliştirilmiştir:

BlogStore.PresentationLayer
Kullanıcı arayüzü, controller sınıfları, ViewComponent’ler, Razor view’lar ve Program.cs gibi başlangıç ayarlarını içerir.

BlogStore.BusinessLayer
Servis ve iş mantığı katmanı. Manager sınıfları ve interface tanımlamaları burada yer alır. SOLID prensipleriyle yazılmıştır.

BlogStore.DataAccessLayer
Entity Framework Core ile veritabanı işlemlerinin gerçekleştiği katman. EfRepository, Context ve migration işlemleri bu katmanda yapılır.

BlogStore.EntityLayer
Projede kullanılan temel varlık sınıfları (Entity’ler). Article, Comment, AppUser, Category gibi domain modellerini içerir.

📸 Ekran Görüntüleri
📌 Ana Sayfa - Blog Listeleme
![image](https://github.com/user-attachments/assets/708d58d5-e0be-4f9b-853d-f779dc822d28)

![image](https://github.com/user-attachments/assets/da757b9a-1dba-467c-b2e5-de9e0cf62250)



📌 Makale Detay Sayfası

![image](https://github.com/user-attachments/assets/9d6e8da5-ecce-42ce-b2b7-3e1db29d0282)


📝 Bir makalenin tam içeriğinin, yazara ait bilgilerle birlikte detaylı olarak gösterildiği ekran.

📌 Yorumlar Bölümü
image 📝 Bir makalenin tam içeriğinin, yazara ait bilgilerle birlikte detaylı olarak gösterildiği ekran.

📌 Yazarlar Sayfası
image 👤 Tüm yazarların görselleriyle birlikte listelendiği, her bir yazarın profiline erişim sağlayan tanıtım ekranı.

📌 Kategoriye Göre Makale Filtreleme
image 📚 Kullanıcıların belirli bir kategori seçerek sadece o kategoriye ait makaleleri görüntüleyebildiği filtreleme ekranı.

📌 Kayıt Ol Sayfası
image 🧾 Yeni kullanıcıların ad, soyad, e-posta ve şifre bilgileriyle sisteme kayıt olduğu form ekranı.

📌 Giriş Yap Sayfası
image 🔐 Sisteme daha önce kayıtlı kullanıcıların giriş yaptığı kullanıcı adı ve şifre formu.

📌 Yazar Profili
image 👨‍💼 Yazarın fotoğrafı, adı, e-posta adresi ve hakkında açıklamalarla birlikte profilinin görüntülendiği sayfa.

📌 Profil Güncelleme
image 🛠️ Yazarların profil fotoğrafı, açıklama ve kişisel bilgilerini düzenleyebildiği sayfa.

📌 Yeni Makale Oluşturma
image 🖊️ Yazarların başlık, görsel, kategori ve içerik belirleyerek yeni bir makale oluşturduğu form sayfası.

📌 Makale Listeleme (Yazara Özel)
image 📑 Sadece oturum açmış yazarın kendi oluşturduğu makaleleri görüntüleyebildiği özel liste ekranı.

📌 Yazar Paneli Dashboard - İstatistik
image 📊 Yazara özel gösterge panelinde, kategorilere göre makale sayılarını ve dağılımını gösteren grafikler.

📌 Yazar Paneli Dashboard - Son İçerikler ve Yorumlar
image 📊 Yazara özel gösterge panelinde, kategorilere göre makale sayılarını ve dağılımını gösteren grafikler.
