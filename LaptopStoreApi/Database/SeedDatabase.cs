﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LaptopStoreApi.Database
{
    public class SeedDatabase
    {
        public static async Task CreateData(IApplicationBuilder app)
        {
            ApiDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<ApiDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Laptops.Any())
            {
                context.Laptops.AddRange(
                    new Laptop
                    {
                        Name = "PREDATOR TRITON 1666",
                        Description =
                            "NVIDIA® GEFORCE RTX™ 40 SERIES LAPTOPS\nIntel® Core™ i9 Processor1\nWINDOWS 11 HOME".Trim(),
                        Type = "Laptop",
                        Price = 1800,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-1.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR TRITON 17 X",
                        Description =
                            "GEFORCE RTX™ 4090\r\nIntel® Core™ i9-13900HX\r\nWINDOWS 11 HOME\r\n32GB DDR5 / 4TB",
                        Type = "Laptop",
                        Price = 1599,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-2.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR HELIOS NEO 16",
                        Description =
                            "GEFORCE RTX™ 4070\r\nIntel® Core™ i7-13700HX\r\nWINDOWS 11 HOME\r\n32GB DDR5 / 2TB",
                        Type = "Laptop",
                        Price = 1599,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-3.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR TRITON 14",
                        Description =
                            "NVIDIA® GEFORCE RTX™ 40 SERIES LAPTOPS\r\nIntel® Core™ i7 Processor1\r\nWINDOWS 11 HOME\r\n32GB LPDDR5",
                        Type = "Laptop",
                        Price = 1599,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-4.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Swift 14",
                        Description =
                            "13th Gen Intel® Core™ H-Series\r\nTwinAir cooling\r\nAntimicrobial Corning® Gorilla® Glass\r\nWINDOWS 11 HOME\r\n",
                        Type = "Laptop",
                        Price = 1599,
                        Color = "Đen",
                        BigPrice = 2000,
                        Quantity = 72,
                        ImgPath = "/images/caro-5.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Nitro 16 AMD",
                        Description =
                            "12th Gen Intel® Core™ processors\r\nTwinAir cooling\r\nAntimicrobial Corning® Gorilla® Glass\r\nWINDOWS 11 HOME\r\n",
                        Type = "Laptop",
                        Price = 6000,
                        BigPrice = 2000,
                        Quantity = 1000,
                        Color = "Đen",
                        ImgPath = "/images/caro-6.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Swift 5",
                        Description =
                            "12th Gen Intel® Core™ processors\r\nTwinAir cooling\r\nAntimicrobial Corning® Gorilla® Glass\r\nWINDOWS 11 HOME\r\n",
                        Type = "Laptop",
                        Price = 1599,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-7.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Swift Edge 16",
                        Description =
                            "AMD Ryzen™ 7040 Series\r\n16-inch, 16:10, 3.2K OLED\r\nAntimicrobial Corning® Gorilla® Glass\r\nWINDOWS 11 HOME\r\n",
                        Type = "Laptop",
                        Price = 1599,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-8.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Swift X AMD",
                        Description =
                            "AMD Ryzen™ 5000 Series1\r\nGeForce RTX™ 3050 Ti1\r\n16GB RAM \r\nWINDOWS 11 HOME\r\n",
                        Type = "Laptop",
                        Price = 1599,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-9.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Nitro 5 Intel",
                        Description =
                            "Intel® Core™ i7 Processors1\r\nGeForce RTX™ 30 Series\r\n32GB, 3200MHZ\r\nWINDOWS 11 HOME\r\n",
                        Type = "Laptop",
                        Price = 1599,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-10.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Nitro 7",
                        Description =
                            "Intel® Core™ i7 Processors1\r\nGeForce RTX™\r\n32GB, 3200MHZ\r\nWINDOWS 11 HOME\r\n",
                        Type = "Laptop",
                        Price = 1599,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-11.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Nitro 7 AMD",
                        Description =
                            "AMD Ryzen™ 7 7840HS\r\nNVIDIA® GeForce RTX™ 4050\r\n16 GB, DDR5 SDRAM\r\n1 TB SSD\r\n",
                        Type = "Laptop",
                        Price = 1200,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 1000,
                        ImgPath = "/images/caro-12.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Nitro 17 AMD",
                        Description =
                            "AMD Ryzen™ 7 7840HS\r\nNVIDIA® GeForce RTX™ 4050\r\n16 GB, DDR5 SDRAM\r\n1 TB SSD\r\n",
                        Type = "Laptop",
                        Price = 1199,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-13.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Nitro 16 AMD",
                        Description =
                            "AMD Ryzen™ 5 7640HS processor\r\nNVIDIA® GeForce RTX™ 4050\r\n8 GB, DDR5 SDRAM\r\n512 GB SSD\r\n",
                        Type = "Laptop",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/caro-14.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR CG48",
                        Description =
                            "4K OLED 3480 x 2160 \n98.5% DCI-P3 Wide Color Gamut \nHDR 10 Media Profile",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk1.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR CG7",
                        Description =
                            "42.5-inch VA Panel \n4K UHD 3480 x 2160 \nHDR 10 Media Profile",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk2.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR X25",
                        Description =
                            "FULL HD 1920 X 1080 \n4K UHD 3480 x 2160 \nZEROFRAME Media Profile",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk3.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR X28",
                        Description =
                            "4K UHD 3840 X 2160 \nUP TO 152Hz 4K UHD 3480 x 2160 \nZEROFRAME Media Profile",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk4.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR X34",
                        Description =
                            "34-inch Agile-Splendor IPS1 \nUP TO 152Hz 4K UHD 3480 x 2160 \nZEROFRAME Media Profile",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk5.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator XB1",
                        Description =
                            "sRGB 100% Coverage IPS1 \nUP TO 152Hz 4K UHD 3480 x 2160 \nULMB Ultra Low Motion Blur",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk6.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR XB3",
                        Description =
                            "Full HD (1920 x 1080) 240 Hz \nDisplayPort, HDMI \nG-sync Compatible",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk7.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR XB3 VISIONCARE",
                        Description =
                            "QHD 2560 X 14401 \n95% DCI-P3 Color Gamut1 \nDELTA E<1 Color Accuracy1",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk8.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR X27",
                        Description =
                            "34-inch Agile-Splendor IPS1 \nUP TO 152Hz 4K UHD 3480 x 2160 \nZEROFRAME Media Profile",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk9.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR X32 FP",
                        Description =
                            "32-INCH 4K 3840 X 21601 UHD \nMINI LED Quantum Dot Technology \n576 ZONES",
                        Type = "LK",
                        Price = 1099,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/lk10.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk1.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk2.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk3.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk4.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk5.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk6.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk7.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk8.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk9.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "Predator Galea 311",
                        Description = "PHW910 | NP.HDS11.00B",
                        Type = "PK",
                        Price = 79,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/pk10.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR BIFROST Intel® Arc™ A770 OC",
                        Description = "APBF-IA770-16G-OC | DP.BKCWW.P02",
                        Type = "Card",
                        Price = 329,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/card1.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR BIFROST Radeon™ RX 7600",
                        Description = "APBF-ARX7600-8G | DP.Z36WW.P01",
                        Type = "Card",
                        Price = 289,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/card2.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR BIFROST Radeon™ RX 7600 OC",
                        Description = "APBF-ARX7600-8G-OC | DP.Z36WW.P02",
                        Type = "Card",
                        Price = 269,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/card3.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    },
                    new Laptop
                    {
                        Name = "PREDATOR BIFROST Intel® Arc™ A750 OC",
                        Description = "APBF-IA750-8G-OC | DP.Z35WW.P01",
                        Type = "Card",
                        Price = 229,
                        BigPrice = 2000,
                        Color = "Đen",
                        Quantity = 72,
                        ImgPath = "/images/card4.webp",
                        CreateDate = DateTime.Now,
                        LastModifiedDate = DateTime.Now,
                    }
                );
                context.LaptopStatuses.AddRange(
                    new LaptopStatus
                    {
                        Images = new List<Image>
                        {
                            new Image { Url = "url1_1.jpg" },
                            new Image { Url = "url1_2.jpg" }
                        },
                        Information = "Máy tính xách tay chơi game thường không đứng đầu danh sách về thiết kế so với một số loại máy tính khác. Chúng thường là những cỗ máy chơi game khổng lồ với rất nhiều RGB và tính thẩm mỹ góc cạnh. Tuy nhiên, laptop Acer Predator Triton 16 lại có kiểu dáng rất đẹp mắt.Với kích thước 35,84 x 26,24 x 2,18 cm, đây là chiếc máy tính xách tay dễ dàng cầm trên tay — được củng cố bởi trọng lượng 2,4kg. Một cách tương đối, bạn có thể nhận thấy rằng Predator không có lợi thế về kích thước mà là trọng lượng nhẹ. Ví dụ: Asus ROG Strix Scar 16 nhỏ hơn về kích thước 35,4 x 36,39 x 2,26 cm, nhưng nặng hơn nhiều với 2.5kg.Nhưng bỏ qua các con số, mẫu laptop Acer này có thiết kế phù hợp với cả gaming và cả dành cho doanh nghiệp. Vỏ ngoài bằng nhựa mờ bóng bẩy, màu bạc tạo cảm giác tuyệt vời khi chạm vào và mang lại cho toàn bộ máy tính xách tay một cảm giác tiện dụng tuyệt vời, giống như những gì bạn nhận được từ MacBook Pro 16 inch.Laptop Acer Predator Triton 16 có màn hình trang bị tấm nền IPS 16 inch 2560 x 1600 pixel với tỷ lệ khung hình 16:10, độ phủ màu 100% DCI-P3 và độ sáng tối đa 500 nit.Màn hình có chất lượng HDR-esque cực kỳ ấn tượng giúp các chủ thể hiển thị sắc nét, độ chính xác màu sắc ấn tượng. Tốc độ làm mới 240Hz cực kỳ mượt mà đảm bảo mọi khung hình sắc nét, không bị giật xé hình. Nếu bạn đang muốn tìm kiếm một laptop gaming cho trải nghiệm hình ảnh tốt thì Acer Predator Triton 16 là sự lựa chọn đáng cân nhắc.",
                        LaptopId = 1
                    },
                    new LaptopStatus
                    {
                        Images = new List<Image>
                        {
                            new Image { Url = "url1_1.jpg" },
                            new Image { Url = "url1_2.jpg" }
                        },
                        Information = "Information for Laptop 2",
                        LaptopId = 2
                    },
                    new LaptopStatus
                    {
                        Images = new List<Image>
                        {
                            new Image { Url = "url1_1.jpg" },
                            new Image { Url = "url1_2.jpg" }
                        },
                        Information = "Information for Laptop 3",
                        LaptopId = 3
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
