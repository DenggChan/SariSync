using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProject.Db
{
    //abstract class so i can inherit(fixed errors)
   public abstract class DbCon
    {
        private readonly string connectionString;

        public DbCon()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\db_users.mdf;Integrated Security=True;Connect Timeout=30";
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);

        }



    }
}
