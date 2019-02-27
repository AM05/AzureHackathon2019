using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace MatcHWebMVCC
{
    public class clsLogin
    {
		public clsLogin()
		{

		}
		protected string ConnectionString { get; set; }

		private string GetConnectionString()
		{
			ConnectionString = "Data Source=.;Initial Catalog=AAB_BANK;Integrated Security=True";
			return ConnectionString;
		}

		public clsLogin(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		internal DbDataReader ExecuteReader(string v, List<DbParameter> parameterList, CommandType storedProcedure)
		{
			throw new NotImplementedException();
		}

		private SqlConnection GetConnection()
		{
			SqlConnection connection = new SqlConnection(this.ConnectionString);
			if (connection.State != ConnectionState.Open)
				connection.Open();
			return connection;
		}

		public bool LoginCheck(string lusername, string lpassword)
		{
			GetConnectionString();
			SqlConnection sqlConn = new SqlConnection(ConnectionString);
			SqlCommand cmd;
			SqlDataReader sreader;
			string sqlQry = "SELECT LOGIN_NAME, PASSWORDS FROM tblUsers WHERE LOGIN_NAME = '" + lusername + "' AND PASSWORDS = '" + lpassword + "';";
			try
			{
				sqlConn.Open();
				cmd = new SqlCommand(sqlQry, sqlConn);
				sreader = cmd.ExecuteReader();
				int recCount = sreader.Cast<object>().Count();
				if (recCount > 0)
				{
					return true;
				}
				else
				{
					return false;
				}
				sreader.Close();
				cmd.Dispose();
				sqlConn.Close();
			}
			finally
			{

			}
		}
	}
}
