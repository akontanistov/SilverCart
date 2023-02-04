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
                bool isTablesExixs = false;

                var dataConnection = scope.ServiceProvider.GetService<AppDataConnection>();
                try
                {
                    dataConnection?.CreateTable<Language>();
                    dataConnection?.CreateTable<Person>();
                }
                catch {
                    isTablesExixs = true;
                }

                if(!isTablesExixs)
                {
                    dataConnection?.BulkCopy(InitializationItems.Languages);
                }
            }
        }
    }
}
