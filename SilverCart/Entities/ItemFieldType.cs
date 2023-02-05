using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SilverCart.Entities
{
    public class ItemFieldType
    {
        [PrimaryKey]
        public int Id { get; set; }
        [NotNull]
        public string Type { get; set; }
    }
}
