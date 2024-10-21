using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Kapanis
{
    public abstract class BaseMachine
    {
        public DateTime Date { get; private set; } // Üretim tarihini saklar
        public string SerialNumber { get; set; } // Seri numarasını saklar
        public string Name { get; set; }  // Ürün adını saklar
        public string Description { get; set; } // Açıklama saklar
        public string OperatingSystem { get; set; } // İşletim sistemini saklar
          
        // Yapıcı Method
        public BaseMachine(string serialNumber, string name, string description, string operatingSystem)
        {
            Date = DateTime.Now; // üretim tarihini otomatik atar
            SerialNumber = serialNumber;
            Name = name;
            Description = description;
            OperatingSystem = operatingSystem;
        }

        // bilgileri yazdırma methodu
        public virtual void WriteInfos()
        {
            Console.WriteLine($"Üretim Tarihi   : {Date}");
            Console.WriteLine($"Seri Numarası   : {SerialNumber}");
            Console.WriteLine($"Ürün Adı        : {Name}");
            Console.WriteLine($"Ürün Açıklaması : {Description}");
            Console.WriteLine($"İşletim Sistemi : {OperatingSystem}");

        }

        //Ürün adını döndüren soyut method
        public abstract string GetProductName();

    }
}
