using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SilverCart.Entities
{
    public class Category
    {
        [PrimaryKey]
        public int Id { get; set; }
        public int? ParentId { get; set; }
    }
}
