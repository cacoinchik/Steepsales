using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Steepsales.Models.EntityFramework
{
    public class EFProductItem : IProductItemRepository
    {
        private readonly AppDbContext context;
        public EFProductItem(AppDbContext context)
        {
            this.context = context;
        }
        public IQueryable<ProductItem> GetProductItems()
        {
            return context.ProductItems;
        }
        public ProductItem GetProductItemById(Guid id)
        {
            return context.ProductItems.FirstOrDefault(x => x.Id == id);
        }
        public void SaveProductItem(ProductItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteProductItem(Guid id)
        {
            context.ProductItems.Remove(new ProductItem() { Id = id });
            context.SaveChanges();
        }
    }
}
