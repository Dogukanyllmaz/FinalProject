using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";

        public static string ProductNameInvalid = "Ürün ismi geçersiz, en az 2 karakter kullanın";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string ProductListed = "Ürünler listelendi";

        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün bulunabilir";

        public static string ProductNameAlreadyExists = "Aynı isimde ürünler eklenemez";

        public static string CategoryLimitExceded = "Kategori en fazla 15 kategori olabilir";

        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string AccessTokenCreated = "Token oluşturuldu";
        internal static string UserRegistered = "Kullanıcı girişi";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = "Hatalı şifre";
        internal static string SuccessfulLogin = "Başarılı giriş";
        internal static string UserAlreadyExists = "Kullanıcı bulunamadı";
    }                                                    
}
