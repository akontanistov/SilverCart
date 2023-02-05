using LinqToDB;
using LinqToDB.Data;
using SilverCart.Data;
using SilverCart.Entities;

namespace SilverCart.Initialization
{
    public static class Initialization
    {
        public static void InitDataBase(WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                bool isTablesExist = false;

                var dataConnection = scope.ServiceProvider.GetService<AppDataConnection>();
                try
                {
                    dataConnection?.CreateTable<Category>();
                    dataConnection?.CreateTable<CategoryName>();
                    dataConnection?.CreateTable<Currency>();
                    dataConnection?.CreateTable<Item>();
                    dataConnection?.CreateTable<ItemAccounting>();
                    dataConnection?.CreateTable<ItemField>();
                    dataConnection?.CreateTable<ItemFieldType>();
                    dataConnection?.CreateTable<ItemFieldTypeName>();
                    dataConnection?.CreateTable<ItemName>();
                    dataConnection?.CreateTable<Language>();
                }
                catch {
                    isTablesExist = true;
                }

                if(!isTablesExist)
                {
                    dataConnection?.BulkCopy(InitializationItems.Currencies);
                    dataConnection?.BulkCopy(InitializationItems.Languages);
                }
            }
        }
    }
}
