using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public decimal EffectsDuration { get; set; }
        public string AdverseEffects { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Guid IdWeb { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string ProductBrand { get; set; }
        public bool IsActive { get; private set; }
        public bool IsPublic { get; private set; }
        
        
    }
}
