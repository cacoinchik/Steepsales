using System;
using System.Linq;

namespace Steepsales.Models.EntityFramework
{
    public interface IProductItemRepository
    {
        IQueryable<ProductItem> GetProductItems();
        ProductItem GetProductItemById(Guid id);
        void SaveProductItem(ProductItem entity);
        void DeleteProductItem(Guid id);
    }
}
