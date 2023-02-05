using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SilverCart.Entities
{
    public class ItemAccounting
    {
        [PrimaryKey]
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int CurrencyId { get; set; }
        public float Price { get; set; }
        public bool DiscountIsActive { get; set; }
        public float Discount { get; set; }
        public int Stock { get; set; }
    }
}
