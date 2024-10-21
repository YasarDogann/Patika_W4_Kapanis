using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Kapanis
{
    public class Phone : BaseMachine
    {
        private bool trLicance;  // Tr lisans durumu

        public bool TrLicance  // Tr lisans özelliği
        {
            get { return trLicance; }
            set
            {
                trLicance = value; //değeri  ayarladık
                if (trLicance)  // lisans durum kontrolü
                {
                    Console.WriteLine("Tr Lisans Mevcut");
                }
            }
        }

        // yapıcı method : base 
        public Phone(string serialNumber, string name, string description, string operatingSystem, bool trLicance) : base(serialNumber, name, description, operatingSystem)
        {
            TrLicance = trLicance; // Tr lisansı ayarlanıyor
        }

        // ürün adını döndürme methodu : override
        public override string GetProductName()
        {
            return $"Telefon Adı : {Name}";
        }

        // bilgileri yazdırma methodu : override
        public override void WriteInfos()
        {
            base.WriteInfos(); // Base sınıf bilgileri yazdırlı
            Console.WriteLine($"Tr Lisans Durum : {TrLicance}"); // lisans durumu yazdırılır
            Console.WriteLine(GetProductName());  // telefon adı yazdırılır
        }
    }
}
