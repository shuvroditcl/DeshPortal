using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace DeshExpressPortal
{
    public class Utlities
    {
        private string selectQuery = "";
        private SqlConnection connectionObj;

        public Utlities()
        {
            connectionObj = Connection();
        }
        private SqlConnection Connection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ImperialDBConnectionString"].ToString();

            //   connectionString= "Data Source=your server name;User ID = your sql server username;Password=Your Sql Server Password;Initial Catalog=Your database name;Integrated Security=True"

            connectionObj = new SqlConnection(connectionString);
            return connectionObj;
        }
        private bool ConnectionStatus()
        {
            if (connectionObj.State == ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

        private SqlConnection ConnectionObj
        {
            get { return connectionObj; }
        }


        private void OpenConnection()
        {
            if (connectionObj.State != ConnectionState.Open)
            {
                connectionObj.Open();
            }
        }

        private void CloseConnection()
        {
            if (connectionObj.State != ConnectionState.Closed)
            {
                connectionObj.Close();
            }
        }
        public double RoundNumber(double x)
        {

            var y = Math.Round(x);

            var z = x - y;

            if (z >= .5)
            {
                y = y + 1;
            }
            return y;
        }



        public string ConvertToMonthDayYear(string date)
        {
            var month = date.Split('/')[1];
            var day = date.Split('/')[0];
            var year = date.Split('/')[2];

            return month + "/" + day + "/" + year;
        }

        public string ConvertToDayMonthYear(string date)
        {
            var month = date.Split('/')[0];
            var day = date.Split('/')[1];
            var year = date.Split('/')[2];

            return day + "/" + month + "/" + year;
        }

        public string ConvertToYearMonthDay(string date)
        {
            var month = date.Split('/')[1];
            var day = date.Split('/')[0];
            var year = date.Split('/')[2];

            return year + "/" + month + "/" + day;
        }


        public SqlDataReader Read(String Sql)
        {
            SqlDataReader sdr = null;
            SqlCommand cmd = null;

            OpenConnection();

            cmd = new SqlCommand(Sql, connectionObj);

            cmd.CommandType = CommandType.Text;

            sdr = cmd.ExecuteReader();
            return sdr;

            CloseConnection();
        }

        public string SaveLogin(string user, string clientIP, string userType)
        {
            string ip = "";
            string insertTable = "";
            string updateTemp = "";
            List<string[]> parameters = new List<string[]>();
            parameters.Add(new string[] { "UserName", user });
            parameters.Add(new string[] { "TypeName", userType });

            selectQuery = "SELECT [LastTime],[LogIn],IP,TypeName FROM [UserTempLog] WHERE UserName=@UserName and TypeName=@TypeName";

            DateTime loginTime = new DateTime();
            DateTime lastTime = new DateTime();
            bool test = false;
            try
            {
                DataTable dt = ReturnTableWithParameter(selectQuery, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    test = true;
                    lastTime = Convert.ToDateTime(row[0].ToString());
                    loginTime = Convert.ToDateTime(row[1].ToString());
                    ip = row[2].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                CloseConnection();
            }


            if (clientIP != ip && ip != "")
                return ip;
            parameters.Add(new string[] { "IP", ip });
            if (test)
            {
                parameters.Add(new string[] { "LogIn", loginTime.ToString() });
                parameters.Add(new string[] { "LogOut", lastTime.ToString() });

                insertTable = @"INSERT INTO [dbo].[UserHistory] ([UserName] ,[IP] ,[LogIn],[LogOut],TypeName) VALUES
                            (@UserName,@IP,@LogIn,@LogOut,@TypeName); ";

                updateTemp = "UPDATE [dbo].[UserTempLog] SET [LogIn] = Getdate() ,[LastTime] =GetDate() WHERE UserName=@UserName";
                if (CommonSqlExecutionRollBackWithParameter(insertTable + updateTemp, parameters) < 1)
                    return ip + " Try again !!!";

            }
            else
            {
                insertTable =
                    "INSERT INTO [dbo].[UserTempLog] ([UserName],[IP],[LogIn],[LastTime],TypeName)VALUES  (@UserName,@IP,GetDate() ,GetDate() ,@TypeName)";
                if (CommonSqlExecutionRollBackWithParameter(insertTable, parameters) < 1)
                    return ip + " Try again !!!";
            }
            return "";
        }

        public void RefreshLogTemp(string user)
        {
            try
            {
                List<string[]> parameters = new List<string[]>();
                parameters.Add(new string[] { "UserName", user });

                string updateTemp = "UPDATE [dbo].[UserTempLog] SET LastTime =GetDate() WHERE UserName=@UserName";
                CommonSqlExecutionBoolWithParameter(updateTemp, parameters);
            }
            catch (Exception ex)
            {
            }
            finally
            {
                CloseConnection();
            }
        }

        public void LogoutUser(string user)
        {
            string insertTable = "";
            string delTemp = "";
            string userType = "";
            string ip = "";
            List<string[]> parameters = new List<string[]>();
            parameters.Add(new string[] { "UserName", user });
            selectQuery = "SELECT [LastTime],[LogIn],IP,TypeName FROM [UserTempLog] WHERE UserName=@UserName";
            DateTime loginTime = new DateTime();
            DateTime lastTime = new DateTime();
            bool test = false;
            try
            {
                DataTable dt = ReturnTableWithParameter(selectQuery, parameters);
                foreach (DataRow row in dt.Rows)
                {
                    test = true;
                    lastTime = Convert.ToDateTime(row[0].ToString());
                    loginTime = Convert.ToDateTime(row[1].ToString());
                    ip = row[2].ToString();
                    userType = row[3].ToString();
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                CloseConnection();
            }


            if (test)
            {
                parameters.Add(new string[] { "IP", ip });
                parameters.Add(new string[] { "LogIn", loginTime.ToString() });
                parameters.Add(new string[] { "LogOut", lastTime.ToString() });
                parameters.Add(new string[] { "TypeName", userType });
                insertTable = @"INSERT INTO [dbo].[UserHistory] ([UserName] ,[IP] ,[LogIn],[LogOut],TypeName) VALUES
                            (@UserName,@IP,@LogIn,@LogOut,@TypeName); ";

                delTemp = " Delete FROM [dbo].[UserTempLog]  WHERE UserName=@UserName";

                CommonSqlExecutionRollBackWithParameter(insertTable + delTemp, parameters);
            }
        }



        public string GetStringValue(string query)
        {
            var value = "";

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (query.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                query = "";
            }
            try
            {
                CloseConnection();
                var dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, ConnectionObj);
                da.SelectCommand.CommandTimeout = 0;
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    value = row[0].ToString();
                }
            }
            catch (Exception ex)
            {
                //  throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }
        public string GetStringValueWithParameter(string queryString, List<string[]> parameters)
        {
            string value = "";

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (queryString.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                queryString = "";
            }

            try
            {

                if (!ConnectionStatus())
                {
                    OpenConnection();
                }
                var dt = new DataTable();
                var da = new SqlDataAdapter(queryString, ConnectionObj);
                da.SelectCommand.CommandTimeout = 0;
                foreach (string[] parameter in parameters)
                {
                    da.SelectCommand.Parameters.Add(parameter[0], parameter[1]);
                }
                da.Fill(dt);
                value = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                //  throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }

        public double GetDoubleValue(string query)
        {
            double value = 0;

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (query.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                query = "";
            }

            try
            {
                CloseConnection();
                var dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(query, ConnectionObj);
                da.SelectCommand.CommandTimeout = 0;
                da.Fill(dt);
                value = Convert.ToDouble(dt.Rows[0][0].ToString());

            }

            catch (Exception ex)
            {
                //  throw ex;
            }
            finally
            {

                CloseConnection();

            }
            return value;
        }
        public double GetDoubleValueWithParameter(string queryString, List<string[]> parameters)
        {
            double value = 0;

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (queryString.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                queryString = "";
            }

            try
            {

                if (!ConnectionStatus())
                {
                    OpenConnection();
                }
                var dt = new DataTable();
                var da = new SqlDataAdapter(queryString, ConnectionObj);
                da.SelectCommand.CommandTimeout = 0;
                foreach (string[] parameter in parameters)
                {
                    da.SelectCommand.Parameters.Add(parameter[0], parameter[1]);
                }
                da.Fill(dt);
                value = Convert.ToDouble(dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                //  throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }

        public int GetIntValue(string query)
        {
            int value = 0;

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (query.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                query = "";
            }

            try
            {

                if (!ConnectionStatus())
                {
                    OpenConnection();
                }
                var dt = new DataTable();
                var da = new SqlDataAdapter(query, ConnectionObj);
                da.SelectCommand.CommandTimeout = 0;
                da.Fill(dt);
                value = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                //  throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }
        public int GetIntValueWithParameter(string queryString, List<string[]> parameters)
        {
            int value = 0;

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (queryString.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                queryString = "";
            }

            try
            {

                if (!ConnectionStatus())
                {
                    OpenConnection();
                }
                var dt = new DataTable();
                var da = new SqlDataAdapter(queryString, ConnectionObj);
                da.SelectCommand.CommandTimeout = 0;
                foreach (string[] parameter in parameters)
                {
                    da.SelectCommand.Parameters.Add(parameter[0], parameter[1]);
                }
                da.Fill(dt);
                value = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                //  throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return value;
        }
        public int CommonSqlExecutionRollBack(string queryString)
        {
            var i = 0;

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (queryString.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                queryString = "";
            }
            string query = @"DECLARE @returnData INT = 0 ; BEGIN TRANSACTION;		BEGIN TRY ";

            try
            {
                OpenConnection();
                query += queryString;
                query += @" SET @returnData = 1
		                COMMIT TRANSACTION;
		                END TRY
		                BEGIN CATCH
		                ROLLBACK TRANSACTION;
		                END CATCH;
                        Select @returnData";
                var mySqlCommandObj = new SqlCommand(query, ConnectionObj);
                mySqlCommandObj.CommandTimeout = 0;
                SqlDataReader reader = mySqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    i = Convert.ToInt32(reader[0]);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return i;
        }
        public int CommonSqlExecutionRollBackWithParameter(string queryString, List<string[]> parameters)
        {
            var i = 0;

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (queryString.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                queryString = "";
            }
            string query = @"DECLARE @returnData INT = 0 ; BEGIN TRANSACTION;		BEGIN TRY ";

            try
            {
                OpenConnection();
                query += queryString;
                query += @" SET @returnData = 1
		                COMMIT TRANSACTION;
		                END TRY
		                BEGIN CATCH
		                ROLLBACK TRANSACTION;
		                END CATCH;
                        Select @returnData";
                var mySqlCommandObj = new SqlCommand(query, ConnectionObj);
                mySqlCommandObj.CommandTimeout = 0;
                foreach (string[] parameter in parameters)
                {
                    mySqlCommandObj.Parameters.Add(parameter[0], parameter[1]);
                }
                SqlDataReader reader = mySqlCommandObj.ExecuteReader();
                while (reader.Read())
                {
                    i = Convert.ToInt32(reader[0]);
                }
            }
            catch (Exception ex)
            {
                //throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return i;
        }
        public bool CommonSqlExecutionBool(string queryString)
        {
            var i = 0;
            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (queryString.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                queryString = "";
            }

            if (!ConnectionStatus())
            {
                OpenConnection();
            }
            try
            {
                var mySqlCommandObj = new SqlCommand(queryString, ConnectionObj);
                mySqlCommandObj.CommandTimeout = 0;
                i = mySqlCommandObj.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //throw ex;
            }
            finally
            {
                CloseConnection();
            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CommonSqlExecutionBoolWithParameter(string queryString, List<string[]> parameters)
        {
            var i = 0;

            if (!ConnectionStatus())
            {
                OpenConnection();
            }

            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (queryString.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 1)
            {

                try
                {
                    var mySqlCommandObj = new SqlCommand(queryString, ConnectionObj);
                    mySqlCommandObj.CommandTimeout = 0;
                    foreach (string[] parameter in parameters)
                    {
                        mySqlCommandObj.Parameters.Add(parameter[0], parameter[1]);
                    }
                    i = mySqlCommandObj.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    //throw ex;
                }
                finally
                {
                    CloseConnection();
                }
            }
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable ReturnTable(string query)
        {
            DataTable table = new DataTable();
            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (query.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 0)
            {
                query = "";
            }
            try
            {
                CloseConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionObj);
                adapter.SelectCommand.CommandTimeout = 0;
                var myDataSet = new DataSet();
                adapter.Fill(myDataSet);
                foreach (DataTable tb in myDataSet.Tables)
                {
                    table = tb;
                }

                // return table; 
            }
            catch (Exception ex)
            {
                ex.HelpLink = ConnectionObj.ToString();
                throw ex;
            }
            finally
            {
                CloseConnection();
            }
            return table;

        }
        public DataTable ReturnTableWithParameter(string query, List<string[]> parameters)
        {
            DataTable table = new DataTable();
            int checkQQ = 1;
            string QQ = @"<div style=""display:none"">";
            if (query.Contains(QQ))
            {
                checkQQ = 0;
            }

            if (checkQQ == 1)
            {

                try
                {
                    CloseConnection();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionObj);
                    adapter.SelectCommand.CommandTimeout = 0;
                    foreach (string[] parameter in parameters)
                    {
                        adapter.SelectCommand.Parameters.Add(parameter[0], parameter[1]);
                    }

                    var myDataSet = new DataSet();
                    adapter.Fill(myDataSet);
                    foreach (DataTable tb in myDataSet.Tables)
                    {
                        table = tb;
                    }

                    // return table; 
                }
                catch (Exception ex)
                {
                    ex.HelpLink = ConnectionObj.ToString();
                    throw ex;
                }
                finally
                {
                    CloseConnection();
                }
            }
            return table;

        }



    }
}