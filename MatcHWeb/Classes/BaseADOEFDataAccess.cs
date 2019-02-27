using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core;

namespace MatcHWeb.Classes
{
	public class BaseADOEFDataAccess
	{
		protected string ConnectionString { get; set; }

		public BaseADOEFDataAccess()
		{
		}

		private string GetConnectionString()
		{
			ConnectionString = "Data Source=.;Initial Catalog=AAB_BANK;Integrated Security=True";
			return ConnectionString;
		}

		public BaseADOEFDataAccess(string connectionString)
		{
			this.ConnectionString = connectionString;
		}

		internal DbDataReader ExecuteReader(string v, List<DbParameter> parameterList, CommandType storedProcedure)
		{
			throw new NotImplementedException();
		}

		private EntityConnection GetConnection()
		{
			// SqlConnection connection = new SqlConnection(this.ConnectionString);
			var connection = new EntityConnection(this.ConnectionString);
			if (connection.State != ConnectionState.Open)
				connection.Open();
			return connection;
		}

		protected EntityCommand GetCommandAEF(DbConnection connection, string commandText, CommandType commandType)
		{
			EntityCommand command = new EntityCommand(commandText, connection as EntityConnection);
			command.CommandType = CommandType.StoredProcedure;
			command.CommandType = commandType;
			return command;
		}

		// protected EntityParameter GetParameterAEF(DbType ltype, string strParamName, object value = null, ParameterDirection parameterDirection = ParameterDirection.Input)
		protected EntityParameter GetParameterAEF(EntityParameter entityParameter)
		{
			EntityParameter parameterObject = new EntityParameter();
			parameterObject = entityParameter;
			parameterObject.ParameterName = entityParameter.ParameterName;
			// parameterObject.DbType = ltype;
			parameterObject.Value = entityParameter.Value;
			return parameterObject;
		}

		protected EntityParameter GetParameterAEFL(DbType ltype, string strParamName, object value = null, ParameterDirection parameterDirection = ParameterDirection.Input)
		{
			EntityParameter parameterObject = new EntityParameter(strParamName, ltype);
			parameterObject.ParameterName = strParamName;
			parameterObject.DbType = ltype;
			parameterObject.Value = value;
			return parameterObject;
		}

		
		protected EntityParameter GetParameterOutAEF(string parameter, DbType type, object value = null, ParameterDirection parameterDirection = ParameterDirection.InputOutput)
		{
			EntityParameter parameterObject = new EntityParameter(parameter, type); 
			
			//if (type == DbType.NVarChar || type == DbType.VarChar || type == DbType.NText || type == DbType.Text)
			if (type == DbType.AnsiString || type == DbType.AnsiStringFixedLength)
			{
				parameterObject.Size = -1;
			}

			parameterObject.Direction = parameterDirection;

			if (value != null)
			{
				parameterObject.Value = value;
			}
			else
			{
				parameterObject.Value = DBNull.Value;
			}

			return parameterObject;
		}

		protected int ExecuteNonQueryAEF(string procedureName, List<DbParameter> parameters, CommandType commandType = CommandType.StoredProcedure)
		{
			int returnValue = -1;
			try
			{
				using (EntityConnection connection = this.GetConnection())
				{
					DbCommand cmd = this.GetCommandAEF(connection, procedureName, commandType);

					if (parameters != null && parameters.Count > 0)
					{
						cmd.Parameters.AddRange(parameters.ToArray());
					}

					returnValue = cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				//LogException("Failed to ExecuteNonQuery for " + procedureName, ex, parameters);  
				throw;
			}
			return returnValue;
		}

				protected object ExecuteScalarAEF(string procedureName, List<EntityParameter> parameters)
		{
			object returnValue = null;
			try
			{
				using (EntityConnection connection = this.GetConnection())
				{
					DbCommand cmd = this.GetCommandAEF(connection, procedureName, CommandType.StoredProcedure);

					if (parameters != null && parameters.Count > 0)
					{
						cmd.Parameters.AddRange(parameters.ToArray());
					}
					returnValue = cmd.ExecuteScalar();
				}
			}
			catch
			{
				//LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);  
				throw;
			}
			return returnValue;
		}

		
		protected DbDataReader GetDataReaderAEF(string procedureName, List<DbParameter> parameters, CommandType commandType = CommandType.StoredProcedure)
		{
			DbDataReader ds;
			try
			{
				EntityConnection connection = this.GetConnection();
				{
					//DbCommand cmd = this.GetCommand(connection, procedureName, commandType);
					EntityCommand cmd = this.GetCommandAEF(connection, procedureName, commandType);
					if (parameters != null && parameters.Count > 0)
					{
						cmd.Parameters.AddRange(parameters.ToArray());
					}

					ds = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				}
			}
			catch
			{
				//LogException("Failed to GetDataReader for " + procedureName, ex, parameters);  
				throw;
			}
			return ds;
		}

		public class clsIT_PROD : BaseADOEFDataAccess
		{
			public EntityDataReader GetITProducts(List<string> lColumnName, List<string> lValue)
			{				
				string strConn1 = GetConnectionString();
				List<int> intList = new List<int>();

				EntityConnection conn = new EntityConnection("name=AAB_BANKEntities");
				conn.Open();
				EntityCommand command = conn.CreateCommand();
				command.CommandText = "AAB_BANKEntities.spGET_IT_PRODUCT_ALL";
				command.CommandType = CommandType.StoredProcedure;
				// EntityCommand command = new EntityCommand();
				EntityParameter paramObjITProd = new EntityParameter();
				EntityDataReader rdr = command.ExecuteReader(CommandBehavior.SequentialAccess);

				if (lColumnName.Count == lValue.Count)
				{
					foreach (string value in lColumnName)
					{
						paramObjITProd.ParameterName = lColumnName.ToString();
						// paramObjITProd.DbType = Convert.ToString(ltype);
						paramObjITProd.Value = lValue;
						command.Parameters.Add(paramObjITProd);
					}
								
					if (rdr.HasRows)
					{
						//while (rdr.Read())
						//{
						//	RefTypeVisitRecord(rdr as IExtendedDataRecord);
						//}
						//var s = rdr.OfType<ITProductsOut>().AsEnumerable();
						//	return (s.ToList());
					}
				}
				//EntityParameter parameterObject = new EntityParameter(strParamName, ltype);
				//parameterObject.ParameterName = strParamName;
				//parameterObject.DbType = ltype;
				//parameterObject.Value = value;
				//return parameterObject;
				return rdr;
				conn.Close();
			}
		}

		//static void RefTypeVisitRecord(IExtendedDataRecord record)
		//{
		//	// For RefType the record contains exactly one field.
		//	int fieldIndex = 0;

		//	// If the field is flagged as DbNull, the shape of the value is undetermined.
		//	// An attempt to get such a value may trigger an exception.
		//	if (record.IsDBNull(fieldIndex) == false)
		//	{
		//		BuiltInTypeKind fieldTypeKind = record.DataRecordInfo.FieldMetadata[fieldIndex].
		//			FieldType.TypeUsage.EdmType.BuiltInTypeKind;
		//		//read only fields that contain PrimitiveType
		//		if (fieldTypeKind == BuiltInTypeKind.RefType)
		//		{
		//			// Ref types are surfaced as EntityKey instances. 
		//			// The containing record sees them as atomic.
		//			EntityKey key = record.GetValue(fieldIndex) as EntityKey;
		//			// Get the EntitySet name.
		//			Console.WriteLine("EntitySetName " + key.EntitySetName);
		//			// Get the Name and the Value information of the EntityKey.
		//			foreach (EntityKeyMember keyMember in key.EntityKeyValues)
		//			{
		//				Console.WriteLine("   Key Name: " + keyMember.Key);
		//				Console.WriteLine("   Key Value: " + keyMember.Value);
		//			}
		//		}
		//	}
		//}

	}
}