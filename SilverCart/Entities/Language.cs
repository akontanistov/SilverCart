using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SilverCart.Entities
{
    /// <summary>
    /// Language by ISO 639, where Code by ISO 639-3 and CodeISO by ISO 639-1
    /// </summary>
    public class Language
    {
        [PrimaryKey, NotNull]
        public string Code { get; set; }
        [NotNull]
        public string CodeISO { get; set; }
        [NotNull]
        public string NameISO { get; set; }
        [NotNull]
        public string NameNative { get; set; }
    }
}
