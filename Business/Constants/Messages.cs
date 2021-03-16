using Entities.Concrete;
using System;
using System.Collections.Generic;
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
	}
}
