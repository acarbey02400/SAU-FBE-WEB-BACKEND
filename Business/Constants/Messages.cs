using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Lütfen en az 2 karakter giriniz";
        public static string ProductsListed = "Ürünler listelendi";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductCountOfCategoryError = "Bu kategorideki maksimum eklenecek ürün sayısına ulaştınız.";
        public static string ProductNameAlreadyExists = "Bu isim daha önce kullanılmış";
        public static string CategoryLimitExceded = "Kategori limitine ulaşıldığı için ürün eklenemiyor";
        public static string AuthorizationDenied = "yetki hatası";
    }
}
