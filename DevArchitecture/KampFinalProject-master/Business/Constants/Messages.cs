using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages  //statik verdiğinde new yapmazsın sabittir
    {                       // bu kısımda mesajların standardizasyonunu yaptık programın değişik yerlerinde fonksiyon gibi
                            //programın değişik yerlerinde fonksiyon gibi kullanabiliriz
        public static string ProductAdded = "Ürün Eklendi!"; //public değişkenler pascal case yazılır
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz!";
        public static string MaintenanceTime="Sistem Bakımda";
        public static object ProductListed="Ürünler Listelendi";

        public static string ProductsListed { get; internal set; }
    }
}
