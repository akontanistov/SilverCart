using LinqToDB.Mapping;
using System.ComponentModel.DataAnnotations;

namespace SilverCart.Entities
{
    /// <summary>
    /// Code by ISO 4217
    /// </summary>
    public class Currency
    {
        [PrimaryKey]
        public string Code { get; set; }
        public char Symbol { get; set; }
    }
}
