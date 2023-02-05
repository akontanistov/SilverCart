using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SilverCart.Entities
{
    public class ItemFieldTypeName
    {
        [PrimaryKey]
        public int Id { get; set; }
        [PrimaryKey]
        public string LanguageCode { get; set; }
        [NotNull]
        public string Name { get; set; }
    }
}
