using Steepsales.Models.EntityFramework;

namespace Steepsales.Models
{
    public class DataManager
    {
        public IProductItemRepository ProductItem { get; set; }
        public DataManager(IProductItemRepository productItem)
        {
            ProductItem = productItem;
        }
    }
}
