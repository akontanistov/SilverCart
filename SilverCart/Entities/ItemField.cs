using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SilverCart.Entities
{
    public class ItemField
    {
        [PrimaryKey]
        public int Id { get; set; }
        [PrimaryKey]
        public string LanguageCode { get; set; }
        [NotNull]
        public string ItemId { get; set; }
        public string ItemFieldTypeId { get; set; }
        public string Value { get; set; }
    }
}
