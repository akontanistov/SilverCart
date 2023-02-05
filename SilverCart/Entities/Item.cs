using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SilverCart.Entities
{
    public class Item
    {
        [PrimaryKey]
        public int Id { get; set; }
        public int? ParentId { get; set; }
    }
}
