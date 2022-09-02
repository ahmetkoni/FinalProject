using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="sistem bakımda";
        public static string ProductsListed="ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride 10 ürün bulunablir.";
        public static string ProductNameAlreadyExists="Bu isimde zaaten başka bir ürün bulunmaktadır.";
        public static string CategorLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied="Yetkiniz yok.";
    }
}
