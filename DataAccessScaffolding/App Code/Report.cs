using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessScaffolding
{
    internal class Report
    {
        public SqlConnection connConnectionClass;

        public void OpenConnections()
        {
            Connection Connection = new Connection();

            this.connConnectionClass = Connection.OpenConnection();
        }

        public void CloseConnections()
        {
            connConnectionClass.Close();

            connConnectionClass = null;
        }

        public DataSet retrieve_db_table_summary()
        {
            string strSQL;
            SqlCommand cmdSQL = new SqlCommand();
            DataSet ds;
            SqlDataAdapter adAdapter;

            //set up the data adapter/data set
            adAdapter = new SqlDataAdapter();
            ds = new DataSet();

            //set up the query
            strSQL = "";
            strSQL = strSQL + "SELECT * FROM INFORMATION_SCHEMA.TABLES ";

            //Set up the command object
            cmdSQL.CommandText = strSQL;
            cmdSQL.Connection = connConnectionClass;

            //Fill The dataset
            adAdapter.SelectCommand = cmdSQL;
            adAdapter.Fill(ds, "tables");

            return ds;
        }

        public DataSet retrieve_params_for_sp(string stored_proc)
        {
            string strSQL;
            SqlCommand cmdSQL = new SqlCommand();
            DataSet ds;
            SqlDataAdapter adAdapter;

            //set up the data adapter/data set
            adAdapter = new SqlDataAdapter();
            ds = new DataSet();

            //set up the query
            strSQL = "";
            strSQL = strSQL + "SELECT name, type_name(user_type_id) as type ";
            strSQL = strSQL + "FROM sys.parameters  ";
            strSQL = strSQL + "WHERE object_id = object_id('" + CommonLib.sqlclean(stored_proc) + "') ";

            //Set up the command object
            cmdSQL.CommandText = strSQL;
            cmdSQL.Connection = connConnectionClass;

            //Fill The dataset
            adAdapter.SelectCommand = cmdSQL;
            adAdapter.Fill(ds, "table");

            return ds;
        }

        public DataSet retrieve_stored_procedures_for_table(string table_name)
        {
            string strSQL;
            SqlCommand cmdSQL = new SqlCommand();
            DataSet ds;
            SqlDataAdapter adAdapter;

            //set up the data adapter/data set
            adAdapter = new SqlDataAdapter();
            ds = new DataSet();

            //set up the query
            strSQL = "";
            strSQL = strSQL + "SELECT [name] ";
            strSQL = strSQL + "FROM sysobjects  ";
            strSQL = strSQL + "WHERE type = 'P' ";
            strSQL = strSQL + "AND category = 0 ";
            strSQL = strSQL + "AND [name] like '" + CommonLib.sqlclean(table_name) + "_SP_%' ";
            strSQL = strSQL + "AND [name] not in ('" + CommonLib.sqlclean(table_name.ToUpper()) + "_SP_SAVE', '" + CommonLib.sqlclean(table_name.ToUpper()) + "_SP_RETRIEVE', '" + CommonLib.sqlclean(table_name.ToUpper()) + "_SP_DELETE') ";

            //Set up the command object
            cmdSQL.CommandText = strSQL;
            cmdSQL.Connection = connConnectionClass;

            //Fill The dataset
            adAdapter.SelectCommand = cmdSQL;
            adAdapter.Fill(ds, "table");

            return ds;
        }

        public DataSet retrieve_db_table_column_summary(string tablename)
        {
            string strSQL;
            SqlCommand cmdSQL = new SqlCommand();
            DataSet ds;
            SqlDataAdapter adAdapter;

            //set up the data adapter/data set
            adAdapter = new SqlDataAdapter();
            ds = new DataSet();

            //set up the query
            strSQL = "";
            strSQL = strSQL + "exec sp_columns " + tablename;

            //Set up the command object
            cmdSQL.CommandText = strSQL;
            cmdSQL.Connection = connConnectionClass;

            //Fill The dataset
            adAdapter.SelectCommand = cmdSQL;
            adAdapter.Fill(ds, "tables");

            return ds;
        }
    }
}