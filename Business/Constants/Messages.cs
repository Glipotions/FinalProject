using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
	public static class Messages
	{
		public static string ProductAdded = "Ürün Eklendi";
		public static string ProductNamedInvalid = "Ürün ismi en az 2 karakter olmalıdır";
		public static string ProductsListed ="Ürün Listelendi";
		public static string MaintenanceTime ="Sistem Bakımda!";
		public static string ProductCountOfCategoryError="Bu kategorideki ürün sayısı sınırı aşıldı!";
		public static string ProductNameAlreadyExists="Bu kategoride zaten bu ürün ismi ile kayıtlı ürün var";
		public static string CategoryLimitExceed="Kategori Limiti aşıldı..!";
		public static string AuthorizationDenied="Yetkiniz yok.";
		public static string UserRegistered="Kullanıcı kaydoldu.";
		public static string UserNotFound="Kullanıcı Bulunamadı!";
		public static string PasswordError="Parola Hatalı";
		public static string SuccessfulLogin="Giriş Başarılı";
		public static string UserAlreadyExists="Kullanıcı zaten bulunuyor!";
		public static string AccessTokenCreated="Token oluşturuldu..";
		public static string CategoryLimitExceded="";
	}
}
