using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Business.Constants
{
    public static class Messages
    {
        public static string NewsAdded = "Yeni Haber Başarıyla Eklendi";
        public static string NewsDeleted = "Haber Başarıyla Silindi";
        public static string NewsUpdated = "Haber Başarıyla Güncellendi";
        public static string NewsNotFound = "Haber Bulunamadı";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Şifre Hatalı";
        public static string SuccessLogin = "Giriş Başarılı";

        public static string UserAlreadyExist = "Bu kullanıcı zaten mevcut";

        public static string UserRegistered = "Kullanıcı Başarıyla Kaydedildi";

        public static string AccessTokenCreated = "Access Token Başarıyla Oluşturuldu";
        public static string OperationClaimDefined = "Yetki başarıyla tanımlandı";
    }
}
