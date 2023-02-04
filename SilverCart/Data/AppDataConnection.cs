using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using SilverCart.Entities;

namespace SilverCart.Data
{
    public class AppDataConnection : DataConnection
    {
        public AppDataConnection(LinqToDBConnectionOptions<AppDataConnection> options) : base(options) { }

        public ITable<Person> People => this.GetTable<Person>();

    }
}
