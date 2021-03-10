using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfProductDal : IProductDal
	{
		public void Add(Product entity)
		{
			using (NorthwindContext context=new NorthwindContext()) // Bunu yapmasakta olur ama bunu yapmak performansı arttırır!
			{
				var addedEntity = context.Entry(entity);
				addedEntity.State = EntityState.Added;
				context.SaveChanges();
			}
		}

		public void Delete(Product entity)
		{
			using (NorthwindContext context = new NorthwindContext()) // Bunu yapmasakta olur ama bunu yapmak performansı arttırır!
			{
				var deleteEntity = context.Entry(entity);
				deleteEntity.State = EntityState.Deleted;
				context.SaveChanges();
			}
		}

		public Product Get(Expression<Func<Product, bool>> filter)
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				return context.Set<Product>().SingleOrDefault(filter);
			}
		}

		public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
		{
			using (NorthwindContext context = new NorthwindContext()) 
			{
				return filter == null 
					? context.Set<Product>().ToList() 
					: context.Set<Product>().Where(filter).ToList();
			}
		}

		public List<Product> GetAllByCategory(int categoryId)
		{
			throw new NotImplementedException();
		}

		public void Update(Product entity)
		{
			using (NorthwindContext context = new NorthwindContext()) // Bunu yapmasakta olur ama bunu yapmak performansı arttırır!
			{
				var updateEntity = context.Entry(entity);
				updateEntity.State = EntityState.Modified;
				context.SaveChanges();
			}
		}
	}
}
