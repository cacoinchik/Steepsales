using System;
using System.ComponentModel.DataAnnotations;

namespace Steepsales.Models.EntityFramework
{
    public abstract class Product
    {
        [Required]
        public Guid Id { get; set; }
        public virtual string Firm { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string Text { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string TitleImage { get; set; }
        [Display(Name = "SEO метатег Title")]
        public string MetaTitle { get; set; }
        [Display(Name = "SEO метатег Description")]
        public string MetaDescription { get; set; }
        [Display(Name = "SEO метатег Keywords")]
        public string MetaKeywords { get; set; }
    }
}
