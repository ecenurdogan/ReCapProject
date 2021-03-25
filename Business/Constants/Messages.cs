using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarAdded = "Ürün Eklendi.";
        public static string CarNameInvalid = "Ürün İsmi Geçersiz.";
        internal static string MaintenanceTime="Sistem Bakımda";
        internal static string CarsListed;
        internal static string CarNameInValid;
        internal static string CarDeleted;
        internal static string CarUpdated;
        internal static string ColorAdded;
        internal static string ColorDeleted;
        internal static string ColorUpdated;
        internal static string ColorListed;
        internal static string BrandAdded;
        internal static string BrandDeleted;
        internal static string BrandUpdated;
        internal static string RentalListed;
        internal static string RentalDeleted;
        internal static string RentalAddedError;
        internal static string RentalAdded;
        internal static string RentalUpdated;
        internal static string CustomerAdded;
        internal static string CustomerDeleted;
        internal static string CustomerUpdated;
        internal static string UserUpdated;
        internal static string UserDeleted;
        internal static string UserAdded;
        internal static string SuccessInserted;
        internal static string ErrorInserted;
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string AccessTokenCreated = "Access token oluşturuldu";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string PasswordError = "Hatalı şifre";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string UserRegistered = "Kullanıcı kayıt edildi";
        internal static string UserListed = "Kullanıcı listelendi";
    }
}
