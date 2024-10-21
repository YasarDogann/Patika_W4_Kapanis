using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_w4_Kapanis
{
    public class Computer : BaseMachine
    {
        private int usbIn; // Usb giriş sayısı

        public int UsbIn // usb giriş sayısı özelliği
        {
            get { return usbIn; }

            set
            {
                if ((value == 2) || (value == 4)) // geçerli sayı kontrolü
                {
                    usbIn = value; // değer ayarlanıyor
                }
                else
                {
                    usbIn = -1; // geçersiz değer
                    Console.WriteLine($"2 veya 4 adet port verilmediği için {usbIn} değeri oldu");  // hata mesajı
                }
            }
        }

        private bool bluetooth;  // bluetooth durumu
        bool Bluetooth  // bluetooth özelliği
        {
            get { return bluetooth; }
            set
            {
                bluetooth = value; // Değer ayarlama
                if (bluetooth)  // bluetooh durum kontrolü
                {
                    Console.WriteLine("Bluetooth mevcut");
                }
            }
        }

        // yapıcı method
        public Computer(string serialNumber, string name, string description, string operatingSystem, int usbIn, bool bluetooth) : base(serialNumber, name, description, operatingSystem)
        {
            UsbIn = usbIn;  // usb girişi ayarlanır
            Bluetooth = bluetooth; // bluetooh durumu ayarlanır
        }

        // ürün adını döndüren method : override
        public override string GetProductName()
        {
            return $"Bilgisyarınızın Adı : {Name}";
        }

        // Bilgileri ekrana yazdırma : override
        public override void WriteInfos()
        {
            base.WriteInfos();
            Console.WriteLine(GetProductName());
        }

    }
}
