using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class Da_Connection
    {

        private Da_Connection() { }

                //Metodo Singlenton
                private static SqlConnection _connection = null;

                public static SqlConnection Get
                {
                    get
                    {
                        if (_connection == null)
                            _connection = new SqlConnection(@"data source = WIN-J5LJSVI0V88\SQLEXPRESS; integrated security = true; initial catalog = Prueba; user id = sa; password = francis3009");
                           // _connection = new SqlConnection(@"workstation id=SmartHearthCareDb.mssql.somee.com;packet size=4096;user id=AppCodee;pwd=AppCodee123;data source=SmartHearthCareDb.mssql.somee.com;persist security info=False;initial catalog=SmartHearthCareDb");
                            //_connection = new SqlConnection(@"Data Source=(local);Initial Catalog=Prueba;Integrated Security=True");
                        return _connection;
                    }
                }


    }

}
