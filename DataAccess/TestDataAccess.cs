using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace MatcHDataAccess
{
    public class TestDataAccess : BaseDataAccess
    {
		public TestDataAccess(string connectionString) : base(connectionString)
		{
		}

		public List<Test> GetTests()
		{
			List<Test> Tests = new List<Test>();
			Test TestItem = null;

			List<DbParameter> parameterList = new List<DbParameter>();

			using (DbDataReader dataReader = base.ExecuteReader("Test_GetAll", parameterList, CommandType.StoredProcedure))
			{
				if (dataReader != null && dataReader.HasRows)
				{
					while (dataReader.Read())
					{
						TestItem = new Test();
						TestItem.TestId = (int)dataReader["TestId"];
						TestItem.Name = (string)dataReader["Name"];

						Tests.Add(TestItem);
					}
				}
			}
			return Tests;
		}

		public Test CreateTest(Test Test)
		{
			List<DbParameter> parameterList = new List<DbParameter>();

			DbParameter TestIdParamter = base.GetParameterOut("TestId", SqlDbType.Int, Test.TestId);
			parameterList.Add(TestIdParamter);
			parameterList.Add(base.GetParameter("Name", Test.Name));

			base.ExecuteNonQuery("Test_Create", parameterList, CommandType.StoredProcedure);

			Test.TestId = (int)TestIdParamter.Value;

			return Test;
		}
	}

	public class Test
	{
		public object TestId { get; internal set; }
		public object Name { get; internal set; }
	}
}
