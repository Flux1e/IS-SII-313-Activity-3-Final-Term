using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.IO;

namespace Inventory
{
    internal class Database
    {
        public static readonly String DBpATH =
                Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    @"..\..\Inventory_db.accdb"
                    );

        private static readonly string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + DBpATH + ";Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {  
            return new OleDbConnection( connectionString );
        }
    }
}
