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
                            //_connection = new SqlConnection(@"data source = francis-pc\SQLEXPRESS; integrated security = true; initial catalog = SCP; user id = sa; password = francis3009");
                            _connection = new SqlConnection(@"workstation id=SmartHearthCareDb.mssql.somee.com;packet size=4096;user id=AppCodee;pwd=AppCodee123;data source=SmartHearthCareDb.mssql.somee.com;persist security info=False;initial catalog=SmartHearthCareDb");
                        return _connection;
                    }
                }
            }


  
}
