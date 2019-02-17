using SharepointHelper.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SharepointHelper.DataBaseLayer
{
    public class DBManager
    {
        static string connectionString = Constants.CONNECTIONSTRING;

        ////////////////////////////// Create SqlCommand object ///////////////////////
        public static SqlCommand GetSQLCommand(string cmdText)
        {
            SqlCommand cmd = null;

            try
            {
                SqlConnection cnnct = new SqlConnection(connectionString);
                cnnct.Open();

                cmd = new SqlCommand(cmdText, cnnct);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Connection.Open();
            }
            catch (Exception Exc)
            {
                if (cmd != null)
                {
                    if (cmd.Connection.State != ConnectionState.Closed)
                    {
                        cmd.Connection.Close();
                    }//if
                    cmd.Dispose();
                }

                throw new Exception(Exc.Message, Exc.InnerException);
            }
            return cmd;
        }


        ////////////////////////////// SQL by Procedure //////////////////////////////
        public static int ExecuteSprocNonQuery(string sprocName, SqlParameter[] prms)
        {
            SqlCommand oComm = null;
            int retVal = 0;

            try
            {
                oComm = GetSQLCommand(sprocName);
                oComm.CommandType = CommandType.StoredProcedure;
                oComm.Parameters.Clear();

                //Set the parameters
                if (prms != null)
                {
                    for (int i = 0; i < prms.Length; i++)
                    {
                        oComm.Parameters.Add(prms[i]);
                    }
                }

                oComm.ExecuteNonQuery();

                if (oComm.Parameters.Contains("@pStatusCode"))
                {
                    retVal = (int)oComm.Parameters["@pStatusCode"].Value;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured trying to run sproc " + sprocName, ex.InnerException);
            }
            finally
            {
                if (oComm != null)
                {
                    if (oComm.Connection.State != ConnectionState.Closed)
                    {
                        oComm.Connection.Close();
                    }
                    oComm.Connection.Dispose();
                    oComm.Dispose();
                }
            }

            return retVal;
        }

        public static object ExecuteSprocScalar(string sprocName, SqlParameter[] prms)
        {
            SqlCommand oComm = null;

            try
            {
                oComm = GetSQLCommand(sprocName);
                oComm.CommandType = CommandType.StoredProcedure;
                oComm.Parameters.Clear();

                //Set the parameters
                if (prms != null)
                {
                    for (int i = 0; i < prms.Length; i++)
                    {
                        oComm.Parameters.Add(prms[i]);
                    }
                }

                return oComm.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured trying to run sproc " + sprocName, ex.InnerException);
            }
            finally
            {
                if (oComm != null)
                {
                    if (oComm.Connection.State != ConnectionState.Closed)
                    {
                        oComm.Connection.Close();
                    }
                    oComm.Connection.Dispose();
                    oComm.Dispose();
                }
            }
        }

        public static DataTable ExecuteSprocDataTable(string sprocName, SqlParameter[] prms)
        {
            SqlDataAdapter da = null;
            SqlCommand oComm = null;

            try
            {
                oComm = GetSQLCommand(sprocName);
                oComm.CommandType = CommandType.StoredProcedure;
                oComm.Parameters.Clear();

                //Set the parameters
                if (prms != null)
                {
                    for (int i = 0; i < prms.Length; i++)
                    {
                        oComm.Parameters.Add(prms[i]);
                    }
                }

                da = new SqlDataAdapter(oComm);
                DataTable dt;
                da.Fill(dt = new DataTable());
                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception("Error occured trying to run sproc " + sprocName, ex.InnerException);
            }
            finally
            {

                if (da != null)
                {
                    da.Dispose();
                }
                if (oComm != null)
                {
                    if (oComm.Connection.State != ConnectionState.Closed)
                    {
                        oComm.Connection.Close();
                    }
                    oComm.Connection.Dispose();
                    oComm.Dispose();
                }

            }
        }
        

        ////////////////////////////// SQL by Statement //////////////////////////////
        public static DataTable ExecuteQueryDataTable(string SQLStatement)
        {
            SqlDataAdapter da = null;
            SqlCommand oComm = null;

            try
            {
                oComm = GetSQLCommand(SQLStatement);
                oComm.CommandType = CommandType.Text;

                da = new SqlDataAdapter(oComm);
                DataTable dt;
                da.Fill(dt = new DataTable());
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured trying to run query: " + SQLStatement, ex.InnerException);
            }
            finally
            {
                if (oComm != null)
                {
                    oComm.Connection.Dispose();
                    oComm.Dispose();
                }

                if (da != null)
                {
                    da.Dispose();
                }
            }
        }

        public static void ExecuteNonQuery(string SQLStatement)
        {
            SqlCommand oComm = null;

            try
            {
                oComm = GetSQLCommand(SQLStatement);
                oComm.CommandType = CommandType.Text;
                oComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occured trying to run query: " + SQLStatement, ex.InnerException);
            }
            finally
            {
                if (oComm != null)
                {
                    if (oComm.Connection.State != ConnectionState.Closed)
                    {
                        oComm.Connection.Close();
                    }
                    oComm.Connection.Dispose();
                    oComm.Dispose();
                }
            }
        }

    }
}
