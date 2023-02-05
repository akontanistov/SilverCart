using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LinqToDB.Mapping;
using SilverCart.Entities;

namespace SilverCart.Data
{
    public class AppDataConnection : DataConnection
    {
        public AppDataConnection(LinqToDBConnectionOptions<AppDataConnection> options) : base(options) {}

        public ITable<Category> Category => this.GetTable<Category>();
        public ITable<CategoryName> CategoryName => this.GetTable<CategoryName>();
        public ITable<Currency> Currency => this.GetTable<Currency>();
        public ITable<Item> Item => this.GetTable<Item>();
        public ITable<ItemAccounting> ItemAccounting => this.GetTable<ItemAccounting>();
        public ITable<ItemField> ItemField => this.GetTable<ItemField>();
        public ITable<ItemFieldType> ItemFieldType => this.GetTable<ItemFieldType>();
        public ITable<ItemFieldTypeName> ItemFieldTypeName => this.GetTable<ItemFieldTypeName>();
        public ITable<ItemName> ItemName => this.GetTable<ItemName>();
        public ITable<Language> Language => this.GetTable<Language>();
    }
}
