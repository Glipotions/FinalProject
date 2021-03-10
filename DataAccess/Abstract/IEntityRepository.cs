using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
	//class: referans Tip
	//IEntity : yanlızca IEntity interface i veya onu kullanan sınıflar olabilir.
	//new() : new lenebilir olan (Yani interface olamaz)
	public interface IEntityRepository<T> where T:class,IEntity,new() //Yukarıda açıklaması yazılan filtreleme işlemi sayesinde sadece veritabanı tabloları kullanılabilir olur.
	{

		List<T> GetAll(Expression<Func<T,bool>> filter=null); // filtrelemek için bu komutu yaparız örnek-> id ye göre filtrele, isme göre filtrele
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
		List<T> GetAllByCategory(int categoryId);

	}
}
