using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Kapanis
{
    public abstract class BaseMachine
    {
        public DateTime Date { get; private set; }
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OperatingSystem { get; set; }

        public BaseMachine(string serialNumber, string name, string description, string operatingSystem)
        {
            Date = DateTime.Now;
            SerialNumber = serialNumber;
            Name = name;
            Description = description;
            OperatingSystem = operatingSystem;
        }
        public virtual void WriteInfos()
        {
            Console.WriteLine($"Üretim Tarihi   : {Date}");
            Console.WriteLine($"Seri Numarası   : {SerialNumber}");
            Console.WriteLine($"Ürün Adı        : {Name}");
            Console.WriteLine($"Ürün Açıklaması : {Description}");
            Console.WriteLine($"İşletim Sistemi : {OperatingSystem}");

        }

        public abstract string GetProductName();

    }
}
