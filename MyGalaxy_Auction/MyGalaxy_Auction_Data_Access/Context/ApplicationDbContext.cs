﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGalaxy_Auction_Data_Access.Domain;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Data_Access.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<PaymentHistory> PaymentHistories { get; set; }
        public DbSet<Electronic> Electronics { get; set; }
        public DbSet<Dress> Dresses { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<MusicalInstrument> MusicalInstruments { get; set; }
//        protected override void OnModelCreating(ModelBuilder builder)
//        {
//            base.OnModelCreating(builder);
//            builder.Entity<Electronic>().HasData(
//    new Electronic { ElectronicId = 1, Brand = "Apple", Model = "iPhone 13", ManufacturingYear = 2021, Price = 999.99m, AuctionPrice = 0.0, AdditionalInformation = "Az kullanılmış, kutulu", IsActive = true, Image = "https://example.com/images/iphone13.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(10), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 2, Brand = "Samsung", Model = "Galaxy S22", ManufacturingYear = 2022, Price = 899.99m, AuctionPrice = 0.0, AdditionalInformation = "Garantili", IsActive = true, Image = "https://example.com/images/s22.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 3, Brand = "Sony", Model = "PlayStation 5", ManufacturingYear = 2020, Price = 699.99m, AuctionPrice = 0.0, AdditionalInformation = "2 kol ile birlikte", IsActive = true, Image = "https://example.com/images/ps5.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(14), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 4, Brand = "Microsoft", Model = "Xbox Series X", ManufacturingYear = 2020, Price = 649.99m, AuctionPrice = 0.0, AdditionalInformation = "Kutu dahil", IsActive = true, Image = "https://example.com/images/xbox.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(9), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 5, Brand = "Dell", Model = "XPS 13", ManufacturingYear = 2021, Price = 1200.00m, AuctionPrice = 0.0, AdditionalInformation = "Hafif çizik", IsActive = true, Image = "https://example.com/images/xps13.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 6, Brand = "HP", Model = "Spectre x360", ManufacturingYear = 2022, Price = 1300.00m, AuctionPrice = 0.0, AdditionalInformation = "Touch ekran", IsActive = true, Image = "https://example.com/images/spectre.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(8), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 7, Brand = "Apple", Model = "MacBook Air M1", ManufacturingYear = 2021, Price = 999.00m, AuctionPrice = 0.0, AdditionalInformation = "Pil döngüsü 50", IsActive = true, Image = "https://example.com/images/macbook.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(11), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 8, Brand = "Lenovo", Model = "ThinkPad X1 Carbon", ManufacturingYear = 2021, Price = 1100.00m, AuctionPrice = 0.0, AdditionalInformation = "İş için ideal", IsActive = true, Image = "https://example.com/images/thinkpad.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 9, Brand = "Canon", Model = "EOS R", ManufacturingYear = 2019, Price = 1500.00m, AuctionPrice = 0.0, AdditionalInformation = "Fotoğrafçılar için ideal", IsActive = true, Image = "https://example.com/images/eosr.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(12), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 10, Brand = "DJI", Model = "Mavic Air 2", ManufacturingYear = 2020, Price = 800.00m, AuctionPrice = 0.0, AdditionalInformation = "Hobi için drone", IsActive = true, Image = "https://example.com/images/mavic.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(10), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 11, Brand = "Samsung", Model = "Galaxy Tab S8", ManufacturingYear = 2022, Price = 600.00m, AuctionPrice = 0.0, AdditionalInformation = "Tablet, kalem dahil", IsActive = true, Image = "https://example.com/images/tabs8.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 12, Brand = "Apple", Model = "iPad Pro", ManufacturingYear = 2021, Price = 1000.00m, AuctionPrice = 0.0, AdditionalInformation = "11 inch ekran", IsActive = true, Image = "https://example.com/images/ipad.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(4), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 13, Brand = "Bose", Model = "QuietComfort 45", ManufacturingYear = 2022, Price = 299.99m, AuctionPrice = 0.0, AdditionalInformation = "Gürültü engelleme", IsActive = true, Image = "https://example.com/images/bose.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(3), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 14, Brand = "Sony", Model = "WH-1000XM4", ManufacturingYear = 2021, Price = 279.99m, AuctionPrice = 0.0, AdditionalInformation = "Kulak üstü kulaklık", IsActive = true, Image = "https://example.com/images/sony.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 15, Brand = "GoPro", Model = "Hero 10", ManufacturingYear = 2021, Price = 399.99m, AuctionPrice = 0.0, AdditionalInformation = "Aksiyon kamerası", IsActive = true, Image = "https://example.com/images/gopro.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 16, Brand = "Asus", Model = "ROG Zephyrus G14", ManufacturingYear = 2022, Price = 1400.00m, AuctionPrice = 0.0, AdditionalInformation = "Oyun bilgisayarı", IsActive = true, Image = "https://example.com/images/rog.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(9), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 17, Brand = "Apple", Model = "Apple Watch Series 7", ManufacturingYear = 2021, Price = 450.00m, AuctionPrice = 0.0, AdditionalInformation = "Akıllı saat", IsActive = true, Image = "https://example.com/images/watch.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(8), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 18, Brand = "Garmin", Model = "Fenix 6", ManufacturingYear = 2020, Price = 500.00m, AuctionPrice = 0.0, AdditionalInformation = "Outdoor saat", IsActive = true, Image = "https://example.com/images/fenix.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 19, Brand = "Razer", Model = "Blade 15", ManufacturingYear = 2022, Price = 1600.00m, AuctionPrice = 0.0, AdditionalInformation = "Gamer laptop", IsActive = true, Image = "https://example.com/images/razer.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(11), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Electronic { ElectronicId = 20, Brand = "LG", Model = "OLED CX", ManufacturingYear = 2020, Price = 1800.00m, AuctionPrice = 0.0, AdditionalInformation = "4K OLED TV", IsActive = true, Image = "https://example.com/images/oled.jpg", StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(13), SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" }
//);



//            builder.Entity<Estate>().HasData(
//    new Estate { EstateId = 1, Title = "Deniz Manzaralı Daire", Description = "Mükemmel manzara", Address = "İstanbul, Beşiktaş", RoomCount = 3, SquareMeters = 120, Price = 3500000, AuctionPrice = 3550000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), IsActive = true, Image = "estate1.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 2, Title = "Lüks Villa", Description = "Havuzlu, güvenlikli site içinde", Address = "İzmir, Urla", RoomCount = 5, SquareMeters = 300, Price = 8500000, AuctionPrice = 8550000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(10), IsActive = true, Image = "estate2.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 3, Title = "Öğrenciye Uygun 1+1", Description = "Metroya yakın", Address = "Ankara, Çankaya", RoomCount = 1, SquareMeters = 45, Price = 750000, AuctionPrice = 760000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), IsActive = true, Image = "estate3.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 4, Title = "Doğa İçinde Ev", Description = "Sessiz sakin ortam", Address = "Bolu, Merkez", RoomCount = 2, SquareMeters = 90, Price = 1200000, AuctionPrice = 1220000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), IsActive = true, Image = "estate4.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 5, Title = "Bahçeli Köy Evi", Description = "Müstakil ve geniş bahçeli", Address = "Balıkesir, Edremit", RoomCount = 3, SquareMeters = 100, Price = 950000, AuctionPrice = 960000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(8), IsActive = true, Image = "estate5.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 6, Title = "Şehir Merkezinde Ofis", Description = "İşlek lokasyon", Address = "İstanbul, Şişli", RoomCount = 2, SquareMeters = 80, Price = 2400000, AuctionPrice = 2430000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(4), IsActive = true, Image = "estate6.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 7, Title = "Satılık Loft Daire", Description = "Yüksek tavanlı modern tasarım", Address = "İstanbul, Kadıköy", RoomCount = 1, SquareMeters = 70, Price = 1700000, AuctionPrice = 1720000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), IsActive = true, Image = "estate7.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 8, Title = "Kiralık Depo Alanı", Description = "Geniş ve yükseklik avantajlı", Address = "Gebze, Kocaeli", RoomCount = 1, SquareMeters = 200, Price = 800000, AuctionPrice = 810000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), IsActive = true, Image = "estate8.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 9, Title = "Yatırım İçin Arsa", Description = "İmarlı tapulu", Address = "Antalya, Manavgat", RoomCount = 0, SquareMeters = 500, Price = 1300000, AuctionPrice = 1320000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(15), IsActive = true, Image = "estate9.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 10, Title = "Boğaz Manzaralı Dubleks", Description = "Eşsiz manzara ve konfor", Address = "İstanbul, Sarıyer", RoomCount = 4, SquareMeters = 180, Price = 6500000, AuctionPrice = 6550000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(10), IsActive = true, Image = "estate10.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 11, Title = "Uygun Fiyatlı Daire", Description = "Yeni yapılmış", Address = "Samsun, Atakum", RoomCount = 2, SquareMeters = 85, Price = 870000, AuctionPrice = 875000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), IsActive = true, Image = "estate11.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 12, Title = "Merkezi Konumda Stüdyo", Description = "Yatırımlık eşyalı", Address = "Bursa, Osmangazi", RoomCount = 1, SquareMeters = 40, Price = 620000, AuctionPrice = 625000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(4), IsActive = true, Image = "estate12.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 13, Title = "Bahçeli Tripleks", Description = "Aile yaşamına uygun", Address = "Eskişehir, Tepebaşı", RoomCount = 5, SquareMeters = 250, Price = 2800000, AuctionPrice = 2820000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(9), IsActive = true, Image = "estate13.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 14, Title = "Yeni Projede 2+1", Description = "Site içerisinde sosyal alanlı", Address = "Konya, Selçuklu", RoomCount = 2, SquareMeters = 95, Price = 1000000, AuctionPrice = 1010000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), IsActive = true, Image = "estate14.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 15, Title = "Dağ Manzaralı Yazlık", Description = "Yaz-kış yaşam için ideal", Address = "Muğla, Fethiye", RoomCount = 3, SquareMeters = 110, Price = 1450000, AuctionPrice = 1465000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), IsActive = true, Image = "estate15.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 16, Title = "Prestijli Ofis Katı", Description = "Kurumsal firmaya özel", Address = "Ankara, Kızılay", RoomCount = 4, SquareMeters = 150, Price = 3900000, AuctionPrice = 3930000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(5), IsActive = true, Image = "estate16.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 17, Title = "Denize Sıfır Villa", Description = "Kendine ait iskeleli", Address = "İzmir, Çeşme", RoomCount = 6, SquareMeters = 400, Price = 12000000, AuctionPrice = 12100000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(12), IsActive = true, Image = "estate17.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 18, Title = "Sakin Sokakta Daire", Description = "Aileye uygun", Address = "Trabzon, Ortahisar", RoomCount = 3, SquareMeters = 100, Price = 900000, AuctionPrice = 905000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(6), IsActive = true, Image = "estate18.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 19, Title = "Konut İmarlı Arsa", Description = "Yola cepheli", Address = "Tekirdağ, Süleymanpaşa", RoomCount = 0, SquareMeters = 600, Price = 1100000, AuctionPrice = 1120000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(14), IsActive = true, Image = "estate19.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Estate { EstateId = 20, Title = "Lüks Rezidans Dairesi", Description = "Site içi, 7/24 güvenlik", Address = "İstanbul, Ataşehir", RoomCount = 2, SquareMeters = 100, Price = 2200000, AuctionPrice = 2220000, StartTime = DateTime.Now, EndTime = DateTime.Now.AddDays(7), IsActive = true, Image = "estate20.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" }
//);


//            builder.Entity<Dress>().HasData(
//    new Dress
//    {
//        DressId = 1,
//        Brand = "Zara",
//        Type = "Elbise",
//        Size = "M",
//        Color = "Kırmızı",
//        Material = "Pamuk",
//        Price = 450.00m,
//        AdditionalInformation = "Yazlık kırmızı elbise.",
//        AuctionPrice = 0,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(7),
//        IsActive = true,
//        Image = "https://example.com/images/dress1.jpg",
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new Dress
//    {
//        DressId = 2,
//        Brand = "Mango",
//        Type = "Ceket",
//        Size = "L",
//        Color = "Siyah",
//        Material = "Polyester",
//        Price = 750.00m,
//        AdditionalInformation = "Şık siyah ceket.",
//        AuctionPrice = 0,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(5),
//        IsActive = true,
//        Image = "https://example.com/images/dress2.jpg",
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new Dress
//    {
//        DressId = 3,
//        Brand = "LC Waikiki",
//        Type = "Pantolon",
//        Size = "S",
//        Color = "Mavi",
//        Material = "Denim",
//        Price = 300.00m,
//        AdditionalInformation = "Kot pantolon.",
//        AuctionPrice = 0,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(6),
//        IsActive = true,
//        Image = "https://example.com/images/dress3.jpg",
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new Dress { DressId = 4, Brand = "H&M", Type = "Elbise", Size = "L", Color = "Beyaz", Material = "Keten", Price = 520.00m, AdditionalInformation = "Keten yazlık elbise.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(8), IsActive = true, Image = "https://example.com/images/dress4.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 5, Brand = "Pull&Bear", Type = "Ceket", Size = "XL", Color = "Lacivert", Material = "Yün", Price = 980.00m, AdditionalInformation = "Kışlık yün ceket.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(10), IsActive = true, Image = "https://example.com/images/dress5.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 6, Brand = "Defacto", Type = "Pantolon", Size = "M", Color = "Siyah", Material = "Pamuk", Price = 270.00m, AdditionalInformation = "Günlük pantolon.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(7), IsActive = true, Image = "https://example.com/images/dress6.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 7, Brand = "Colins", Type = "Kot Ceket", Size = "L", Color = "Açık Mavi", Material = "Denim", Price = 680.00m, AdditionalInformation = "Şık kot ceket.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(9), IsActive = true, Image = "https://example.com/images/dress7.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 8, Brand = "Stradivarius", Type = "Etek", Size = "S", Color = "Pembe", Material = "Polyester", Price = 240.00m, AdditionalInformation = "Kısa yazlık etek.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(4), IsActive = true, Image = "https://example.com/images/dress8.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 9, Brand = "Bershka", Type = "Mont", Size = "XL", Color = "Gri", Material = "Polyester", Price = 1100.00m, AdditionalInformation = "Kışlık mont.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(11), IsActive = true, Image = "https://example.com/images/dress9.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 10, Brand = "Zara", Type = "Elbise", Size = "M", Color = "Mor", Material = "İpek", Price = 1300.00m, AdditionalInformation = "Gece elbisesi.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(12), IsActive = true, Image = "https://example.com/images/dress10.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 11, Brand = "H&M", Type = "Ceket", Size = "S", Color = "Yeşil", Material = "Pamuk", Price = 620.00m, AdditionalInformation = "Rahat ceket.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(6), IsActive = true, Image = "https://example.com/images/dress11.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 12, Brand = "Koton", Type = "Pantolon", Size = "L", Color = "Bej", Material = "Pamuk", Price = 340.00m, AdditionalInformation = "Günlük kullanım için.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(8), IsActive = true, Image = "https://example.com/images/dress12.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 13, Brand = "Pull&Bear", Type = "Gömlek", Size = "M", Color = "Krem", Material = "Pamuk", Price = 260.00m, AdditionalInformation = "Klasik gömlek.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(7), IsActive = true, Image = "https://example.com/images/dress13.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 14, Brand = "Zara", Type = "Etek", Size = "S", Color = "Siyah", Material = "İpek", Price = 500.00m, AdditionalInformation = "Klasik siyah etek.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(9), IsActive = true, Image = "https://example.com/images/dress14.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 15, Brand = "Defacto", Type = "Mont", Size = "XL", Color = "Kahverengi", Material = "Yün", Price = 950.00m, AdditionalInformation = "Sıcak tutar.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(13), IsActive = true, Image = "https://example.com/images/dress15.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 16, Brand = "Colins", Type = "Pantolon", Size = "M", Color = "Gri", Material = "Pamuk", Price = 380.00m, AdditionalInformation = "Ofis stili.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(10), IsActive = true, Image = "https://example.com/images/dress16.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 17, Brand = "Mavi", Type = "Kot Ceket", Size = "L", Color = "Koyu Mavi", Material = "Denim", Price = 740.00m, AdditionalInformation = "Klasik model.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(8), IsActive = true, Image = "https://example.com/images/dress17.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 18, Brand = "Koton", Type = "Elbise", Size = "M", Color = "Turuncu", Material = "Keten", Price = 430.00m, AdditionalInformation = "Yazlık mini elbise.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(6), IsActive = true, Image = "https://example.com/images/dress18.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 19, Brand = "LC Waikiki", Type = "Etek", Size = "S", Color = "Bordo", Material = "Pamuk", Price = 210.00m, AdditionalInformation = "Uygun fiyatlı.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(5), IsActive = true, Image = "https://example.com/images/dress19.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" },
//    new Dress { DressId = 20, Brand = "H&M", Type = "Gömlek", Size = "M", Color = "Beyaz", Material = "Keten", Price = 290.00m, AdditionalInformation = "Nefes alır kumaş.", AuctionPrice = 0, StartTime = DateTime.UtcNow, EndTime = DateTime.UtcNow.AddDays(12), IsActive = true, Image = "https://example.com/images/dress20.jpg", SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079" }
//    );
//            builder.Entity<MusicalInstrument>().HasData(
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 1,
//        Name = "Yamaha Acoustic Guitar",
//        Brand = "Yamaha",
//        Description = "Great tone, excellent for beginners and professionals.",
//        Price = 1200.00m,
//        Image = "https://images.musicstore.de/images/1280/yamaha-fg800-natural_1_GIT0044595-000.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(7),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 2,
//        Name = "Roland Digital Piano",
//        Brand = "Roland",
//        Description = "88 weighted keys, great for classical and modern styles.",
//        Price = 3500.00m,
//        Image = "https://static.roland.com/assets/images/products/gallery/fp-30x_black_top_gal.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(10),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 3,
//        Name = "Fender Electric Guitar",
//        Brand = "Fender",
//        Description = "Classic Stratocaster style, great for rock and blues.",
//        Price = 4200.00m,
//        Image = "https://www.fmicassets.com/Damroot/Lg/10001/0144502500_gtr_frt_001_rr.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(5),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 4,
//        Name = "Pearl Drum Set",
//        Brand = "Pearl",
//        Description = "Full drum kit for studio and live performance.",
//        Price = 5800.00m,
//        Image = "https://m.media-amazon.com/images/I/71ubtvvV2BL._AC_SL1500_.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(14),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 5,
//        Name = "Bose Sound System",
//        Brand = "Bose",
//        Description = "High quality, clear sound system for musicians.",
//        Price = 2500.00m,
//        Image = "https://www.bose.com/content/dam/Bose_DAM/Web/consumer_web/portable/portable_speakers/portable_speakers_front_0_0.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(6),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 6,
//        Name = "Casio Keyboard",
//        Brand = "Casio",
//        Description = "Compact, versatile keyboard with built-in sounds.",
//        Price = 550.00m,
//        Image = "https://images.casio.com/us/casio-keyboard/sa76.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(8),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 7,
//        Name = "Ibanez Electric Guitar",
//        Brand = "Ibanez",
//        Description = "Famous for its thin neck and high-speed playability.",
//        Price = 1500.00m,
//        Image = "https://www.ibanez.com/electric-guitars/rg/RG350DX_BKN_01.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(12),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 8,
//        Name = "Korg Synthesizer",
//        Brand = "Korg",
//        Description = "Professional-grade synthesizer for music production.",
//        Price = 3000.00m,
//        Image = "https://www.korg.com/us/products/dj/sq1/images/sq1_photo_01.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(9),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 9,
//        Name = "Ludwig Drum Kit",
//        Brand = "Ludwig",
//        Description = "Vintage drum set with excellent sound quality.",
//        Price = 4500.00m,
//        Image = "https://m.media-amazon.com/images/I/81TcWrq8JrL._AC_SL1500_.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(7),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 10,
//        Name = "Shure Microphone",
//        Brand = "Shure",
//        Description = "High quality vocal microphone, great for studio recordings.",
//        Price = 350.00m,
//        Image = "https://static.shure.com/fgf/7fc/07e/0c51c0cd8cfb61d75d.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(6),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 11,
//        Name = "Sennheiser Headphones",
//        Brand = "Sennheiser",
//        Description = "Studio quality headphones with excellent noise cancellation.",
//        Price = 250.00m,
//        Image = "https://www.sennheiser.com/media/global/hd660s-m0m.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(11),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 12,
//        Name = "Mackie Studio Monitors",
//        Brand = "Mackie",
//        Description = "Professional studio monitors for accurate sound mixing.",
//        Price = 1800.00m,
//        Image = "https://www.mackie.com/sites/default/files/styles/product_gallery/public/2018-06/mr5mk3-front-grill_0.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(13),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 13,
//        Name = "Tama Drum Set",
//        Brand = "Tama",
//        Description = "Full 5-piece drum kit for drummers of all levels.",
//        Price = 4000.00m,
//        Image = "https://www.tama.com/eu/wp-content/uploads/sites/2/2020/06/Starclassic.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(8),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 14,
//        Name = "Roland Drum Pads",
//        Brand = "Roland",
//        Description = "Electronic drum pads with great sensitivity and response.",
//        Price = 1200.00m,
//        Image = "https://static.roland.com/assets/images/products/gallery/spd-sx-top-gallery.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(12),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 15,
//        Name = "Gretsch Electric Guitar",
//        Brand = "Gretsch",
//        Description = "Known for its smooth tone, great for jazz and blues.",
//        Price = 2200.00m,
//        Image = "https://www.gretschguitars.com/uploads/media/default/0001/05/8e98d84bdfef0a25d5bcf95a59e682ee105580de.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(9),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 16,
//        Name = "Vox Amplifier",
//        Brand = "Vox",
//        Description = "Classic British tone, perfect for rock guitarists.",
//        Price = 1500.00m,
//        Image = "https://www.voxamps.com/wp-content/uploads/2019/10/AC30_C1_3Q_copy.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(15),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 17,
//        Name = "Martin Acoustic Guitar",
//        Brand = "Martin",
//        Description = "Legendary acoustic guitars known for their excellent sound.",
//        Price = 3000.00m,
//        Image = "https://images.martinguitar.com/assets/guitars/000-15M.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(14),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 18,
//        Name = "Peavey Bass Guitar",
//        Brand = "Peavey",
//        Description = "Great bass guitar for beginners and intermediate players.",
//        Price = 800.00m,
//        Image = "https://www.peavey.com/media/wysiwyg/artist/Bass/Bass_Guitar.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(10),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 19,
//        Name = "Line 6 Guitar Amp",
//        Brand = "Line 6",
//        Description = "Modern amp with tons of effects and high-quality sound.",
//        Price = 1300.00m,
//        Image = "https://line6.com/wp-content/uploads/2020/02/HelixLT_Studio_Guitar_Amplifier.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(11),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    },
//    new MusicalInstrument
//    {
//        MusicalInstrumentId = 20,
//        Name = "Pearl Snare Drum",
//        Brand = "Pearl",
//        Description = "High-quality snare drum, great for any drum set.",
//        Price = 350.00m,
//        Image = "https://images.pearldrum.com/wp-content/uploads/sites/2/2020/04/pearl-snare.jpg",
//        IsActive = true,
//        StartTime = DateTime.UtcNow,
//        EndTime = DateTime.UtcNow.AddDays(12),
//        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//    }
//    );



//            builder.Entity<Vehicle>().HasData(
//                                        new Vehicle
//                                        {
//                                            VehicleId = 1,
//                                            BrandAndModel = "Toyota Camry",
//                                            ManufacturingYear = 2020,
//                                            Color = "Silver",
//                                            EngineCapacity = 2.5m,
//                                            Price = 25000.00m,
//                                            Millage = 15000,
//                                            PlateNumber = "34AA21",
//                                            AuctionPrice = 0.0,
//                                            AdditionalInformation = "Excellent condition, single owner",
//                                            StartTime = DateTime.Now,
//                                            EndTime = DateTime.Now.AddDays(48),
//                                            IsActive = true,
//                                            Image = "https://i.gaw.to/content/photos/39/21/392165_2020_Toyota_Camry.jpg",
//                                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                                        },
//                    new Vehicle
//                    {
//                        VehicleId = 2,

//                        BrandAndModel = "Honda Civic",
//                        ManufacturingYear = 2019,
//                        Color = "Blue",
//                        EngineCapacity = 1.8m,
//                        Price = 18000.00m,
//                        Millage = 20000,
//                        PlateNumber = "34AA21",
//                        AuctionPrice = 0.0,
//                        AdditionalInformation = "Good condition, one previous owner",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(24),
//                        IsActive = false,
//                        Image = "https://i.pinimg.com/originals/4f/b7/96/4fb796d99758f4889338c69efc74dbfe.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//                    },
//                    new Vehicle
//                    {
//                        VehicleId = 3,

//                        BrandAndModel = "Ford F-150",
//                        ManufacturingYear = 2018,
//                        Color = "Red",
//                        EngineCapacity = 5.0m,
//                        Price = 28000.00m,
//                        Millage = 25000,
//                        PlateNumber = "34AA21",
//                        AuctionPrice = 0.0,
//                        AdditionalInformation = "Low mileage, well-maintained",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(72),
//                        IsActive = true,
//                        Image = "https://www.autopartmax.com/images/cUpload/FORD%20Truck-F150%20Raptor.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                    },
//                    new Vehicle
//                    {
//                        VehicleId = 4,

//                        BrandAndModel = "Nissan Altima",
//                        ManufacturingYear = 2017,
//                        Color = "Black",
//                        EngineCapacity = 2.5m,
//                        Price = 16000.00m,
//                        Millage = 30000,
//                        PlateNumber = "34AA21",
//                        AuctionPrice = 0.0,
//                        AdditionalInformation = "Great condition, low mileage",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(48),
//                        IsActive = true,
//                        Image = "https://www.jonathanmotorcars.com/imagetag/631/3/l/Used-2017-Nissan-Altima-25-SV-Premium.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                    },
//                    new Vehicle
//                    {
//                        VehicleId = 5,

//                        BrandAndModel = "Chevrolet Malibu",
//                        ManufacturingYear = 2017,
//                        Color = "Silver",
//                        EngineCapacity = 2.4m,
//                        Price = 15500.00m,
//                        Millage = 28000,
//                        AuctionPrice = 0.0,
//                        PlateNumber = "34AA21",
//                        AdditionalInformation = "Well-maintained, single owner",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(72),
//                        IsActive = true,
//                        Image = "https://cdn.carbuzz.com/gallery-images/2016-chevrolet-malibu-carbuzz-489817-1600.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                    },
//                    new Vehicle
//                    {
//                        VehicleId = 6,

//                        BrandAndModel = "Ferrari 488 GTB",
//                        ManufacturingYear = 2022,
//                        Color = "Red",
//                        EngineCapacity = 3.9m,
//                        Price = 300000.00m,
//                        PlateNumber = "34AA21",
//                        Millage = 1000,
//                        AuctionPrice = 0.0,
//                        AdditionalInformation = "Like new, low mileage",
//                        StartTime = DateTime.Now,
//                        EndTime = DateTime.Now.AddDays(48),
//                        IsActive = true,
//                        Image = "https://i.pinimg.com/originals/93/2e/fb/932efb625cc97155497cfabd53a57d71.jpg",
//                        SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                    },
//                        new Vehicle
//                        {
//                            VehicleId = 7,

//                            BrandAndModel = "Lamborghini Huracan",
//                            ManufacturingYear = 2021,
//                            Color = "Yellow",
//                            EngineCapacity = 5.2m,
//                            PlateNumber = "34AA21",
//                            Price = 280000.00m,
//                            Millage = 2000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Excellent condition, one owner",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://w.forfun.com/fetch/03/033f1bda44fe68f0aaa4db19f84a2e54.jpeg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 8,
//                            BrandAndModel = "Porsche 911",
//                            ManufacturingYear = 2020,
//                            Color = "White",
//                            EngineCapacity = 3.0m,
//                            Price = 180000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 5000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Low mileage, well-maintained",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://avatars.mds.yandex.net/get-autoru-vos/6209275/1ee5dfabd4030a68195d9ac37ebf08b2/1200x900",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 9,
//                            BrandAndModel = "Aston Martin DB11",
//                            ManufacturingYear = 2019,
//                            Color = "Black",
//                            EngineCapacity = 5.2m,
//                            Price = 250000.00m,
//                            Millage = 6000,
//                            AuctionPrice = 0.0,
//                            PlateNumber = "34AA21",
//                            AdditionalInformation = "Excellent condition, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://images.hgmsites.net/hug/2018-aston-martin-db11_100630564_h.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 10,
//                            BrandAndModel = "McLaren 720S",
//                            ManufacturingYear = 2021,
//                            Color = "Orange",
//                            EngineCapacity = 4.0m,
//                            Price = 280000.00m,
//                            Millage = 4000,
//                            PlateNumber = "34AA21",
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Like new, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://www.mclarencf.com/imagetag/42/main/l/New-2020-McLaren-720S-Spider.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 11,
//                            BrandAndModel = "Bugatti Chiron",
//                            ManufacturingYear = 2018,
//                            Color = "Blue",
//                            EngineCapacity = 8.0m,
//                            Price = 350000.00m,
//                            Millage = 3000,
//                            PlateNumber = "34AA21",
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Rare, collector's item",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://coolwallpapers.me/picsup/5650604-bugatti-chiron-wallpapers.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 12,
//                            BrandAndModel = "Koenigsegg Jesko",
//                            ManufacturingYear = 2022,
//                            Color = "Silver",
//                            EngineCapacity = 5.0m,
//                            Price = 400000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 1500,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance masterpiece",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://wallpapercave.com/wp/wp5031567.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 13,
//                            BrandAndModel = "Ferrari SF90 Stradale",
//                            ManufacturingYear = 2021,
//                            Color = "Red",
//                            EngineCapacity = 4.0m,
//                            PlateNumber = "34AA21",
//                            Price = 275000.00m,
//                            Millage = 2000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Hybrid supercar, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://4kwallpapers.com/images/wallpapers/novitec-ferrari-sf90-stradale-2022-5k-8k-2880x1800-8481.jpeg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 14,
//                            BrandAndModel = "Pagani Huayra",
//                            ManufacturingYear = 2020,
//                            Color = "Green",
//                            EngineCapacity = 6.0m,
//                            Price = 320000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 2500,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Exotic masterpiece, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://www.motorionline.com/wp-content/gallery/pagani-huayra-nc/Pagani-Huayra-NC-1.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 15,
//                            BrandAndModel = "Lexus LC 500",
//                            ManufacturingYear = 2019,
//                            Color = "Black",
//                            EngineCapacity = 5.0m,
//                            Price = 60000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 5000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Luxury sports coupe",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://wallpapercave.com/wp/wp6603188.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 16,
//                            BrandAndModel = "Tesla Model S",
//                            ManufacturingYear = 2022,
//                            Color = "Blue",
//                            EngineCapacity = 0.0m,  // Elektrikli araç, motor kapasitesi yok
//                            Price = 90000.00m,
//                            Millage = 1500,
//                            PlateNumber = "34AA21",
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance electric car",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://i.pinimg.com/originals/8f/b4/3b/8fb43b750028af047cbb0308c0e46014.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 17,
//                            BrandAndModel = "Audi R8",
//                            ManufacturingYear = 2021,
//                            Color = "Silver",
//                            EngineCapacity = 5.2m,
//                            Price = 120000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 3000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Luxury sports car, low mileage",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://wallpapercave.com/wp/wp8343229.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 18,
//                            BrandAndModel = "Mercedes-AMG GT",
//                            ManufacturingYear = 2020,
//                            Color = "Black",
//                            EngineCapacity = 4.0m,
//                            Price = 110000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 4000,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance luxury car",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://images.hdqwalls.com/download/mercedes-benz-sls-amg-yellow-5k-hv-3840x2400.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 19,
//                            BrandAndModel = "Nissan GT-R",
//                            ManufacturingYear = 2021,
//                            Color = "Blue",
//                            EngineCapacity = 3.8m,
//                            PlateNumber = "34AA21",
//                            Price = 95000.00m,
//                            Millage = 2500,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance Japanese sports car",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://i.pinimg.com/originals/e9/75/81/e97581a73660b583b1d982ef23607c24.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {

//                            VehicleId = 20,
//                            BrandAndModel = "Ford Mustang Shelby GT500",
//                            ManufacturingYear = 2022,
//                            Color = "Red",
//                            EngineCapacity = 5.2m,
//                            Price = 75000.00m,
//                            PlateNumber = "34AA21",
//                            Millage = 1500,
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "High-performance American muscle car",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(72),
//                            IsActive = true,
//                            Image = "https://www.mustangspecs.com/wp-content/uploads/2022/09/carpixel.net-2022-shelby-gt500-mustang-heritage-edition-106565-hd.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"

//                        },
//                        new Vehicle
//                        {
//                            VehicleId = 21,
//                            BrandAndModel = "Porsche Cayman GT4",
//                            ManufacturingYear = 2021,
//                            Color = "Yellow",
//                            EngineCapacity = 4.0m,
//                            Price = 95000.00m,
//                            Millage = 3500,
//                            PlateNumber = "34AA21",
//                            AuctionPrice = 0.0,
//                            AdditionalInformation = "Sports car with exceptional handling",
//                            StartTime = DateTime.Now,
//                            EndTime = DateTime.Now.AddDays(48),
//                            IsActive = true,
//                            Image = "https://media.porsche.com/mediakit/718-cayman-gt4-rs/00-photos/media-drive/718-Cayman-GT4-RS-GT-silbermetallic-S-GO1306/image-thumb__47840__mk2-modal-item/porschecayman_estoril07005_high_1.jpg",
//                            SellerId = "9defb4b8-7df0-4f6a-a49a-ddc0c68c9079"
//                        }
//        );
//        }
    }
}
