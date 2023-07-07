using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";
        public static string MaintenanceTime = "Sistem bakımda. Daha sonra tekrar deneyiniz.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandsListed = "Markalar listelendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string ColorAdded = "Renk eklendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorsListed = "Renkler listelendi.";
        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string RentalAdded = "Kiralama işlemi gerçekleşti.";
        public static string RentalDeleted = "Kiralama işlemi silindi.";
        public static string RentalUpdated = "Kiralama işlemi güncellendi.";
        public static string RentalsListed = "Kiralama işlemleri listelendi.";
        public static string CarImagesListed = "Araba resimleri listelendi.";
        public static string CarImageDeleted = "Araba resmi silindi.";
        public static string CarImageAdded = "Araba resmi eklendi.";
        public static string CarImageUpdated = "Araba resmi güncellendi.";
        public static string CarImageLimitExceeded = "Resim sınırı aşıldı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Başarılı giriş.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı oluşturuldu.";
        public static string AccessTokenCreated = "Kullanıcı token oluşturuldu.";
        public static string  AuthorizationDenied = "Yetkiniz yok.";
    }
}
