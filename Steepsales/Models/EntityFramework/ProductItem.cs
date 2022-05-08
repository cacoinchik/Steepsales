using System.ComponentModel.DataAnnotations;

namespace Steepsales.Models.EntityFramework
{
    public class ProductItem : Product
    {
        [Required(ErrorMessage = "Обозначьте фирму")]
        public override string Firm { get; set; }
        [Required(ErrorMessage = "Обозначьте модель")]
        public override string Name { get; set; }
        public override string Description { get; set; }
        public override string Text { get; set; }
        public override decimal Price { get; set; }
        public override int FirmId { get; set; }
        public override int TypeId { get; set; }
    }
}
