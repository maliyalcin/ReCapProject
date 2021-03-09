using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string CarNameInvalid = "Ürün ismi geçersiz.";
        public static string CarAdded = "Ürün Eklendi";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string CarRentalListed = " Ürünler Listelendi";
        public static string BrandList = "Markalar Listelendi.";
        public static string BrandNameInvalid = "Marka İsmi Geçersiz";
        public static string BrandAdded = "Marka Eklendi.";
        public static string BrandUpdated = "Marka Güncellendi.";
        public static string BrandDeleted = "Marka Silindi.";
        public static string CarList = "Arabalar Listelendi.";
        public static string CarRentalAdded = "Araba Kiralama eklendi.";
        public static string CarUpdated = "Araba Güncellendi.";
        public static string CarDeleted = "Araba Başarıyla Silindi.";
        public static string ColorListed = "Renkler Listelendi.";
        public static string ColorNameInvalid = "Renk İsmi Geçersiz.";
        public static string ColorAdded = "Renk Başarıyla Eklendi.";
        public static string ColorUpdated = "Renk Güncellendi.";
        public static string ColorDeleted = "Renk Güncelledi.";
        public static string CompanyNameInvalid = "Şirket Adı Geçersiz.";
        public static string CustomerAdded = "Müşteri Başarıyla Eklendi.";
        public static string CustomerUpdated = "Müşteri Güncellendi.";
        public static string CustomerDeleted = "Müşteri Silindi.";
        public static string CustomerList = "Müşteriler Listelendi.";
        public static string UserDeleted = "Kullanıcı Silindi.";
        public static string UserUpdated = "Kullanıcı Güncellendi.";
        public static string UserAdded = "Kullanıcı Başarıyla Eklendi.";
        public static string UserNameInvalid = "Kullanıcı Adı Geçersiz.";
        public static string UserList = "Kullanıcılar Listelendi.";
        public static string CarRentalUpdated = "Araba kiralama bilgileri güncellendi.";
        public static string CarRentalDeleted = "Araba kiralama bilgileri silindi.";
        public static string UserCountError = "En fazla 10 kullanıcı eklenebilir.";
        public static string UserNameAlreadyExists = "Bu isimde başka bir kullanıcı var.";
        public static string CustomerLimiExceded = "Müşteri Limitini Aştınız.";
        public static string ExceededAddedImageLimit = "Resim ekleme limiti aşıldı.";
        public static string AuthorizationDenied="Yetkiniz Yok.";
        public static string UserRegistered="Kullanıcı kayıt oldu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Parola Hatası.";
        public static string SuccessfulLogin="Başarılı giriş.";
        public static string UserAlreadyExists="Kullanıcı Mevcut.";
        public static string AccessTokenCreated="Token Oluşturuldu.";
    }
}
