using System.Configuration;
using System.Data.Common;

namespace Exp.Infra.Data.ADO
{
    public class Conn
    {
        private readonly DbConnection _conn;

        public Conn(string connectionString)
        {
            ConnectionStringSettings css = ConfigurationManager.ConnectionStrings[connectionString];

            DbProviderFactory dbProviderFactory = DbProviderFactories.GetFactory(css.ProviderName);

            _conn = dbProviderFactory.CreateConnection();
        }
    }
}