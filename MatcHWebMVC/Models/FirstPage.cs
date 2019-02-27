using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatcHWebMVCC.Models
{
    public class FirstPage
    {

		[Key]
		public int PDDID { get; set; }

		SqlConnection con = new SqlConnection();
		List<FirstPage> FirstPageList = new List<FirstPage>();
		public String pdd_status { get; set; }
		public String Blocker { get; set; }
		public String SRQStatus { get; set; }
		public string IT_Product_name { get; set; }
		public string AllWaveNos { get; set; }
		FirstPage p = null;
		

		public List<FirstPage> GetFirstPage()
		{
			string ConnectionString = "Data Source=.;Initial Catalog=AAB_BANK;Integrated Security=True";
			con.ConnectionString = ConnectionString;

			 con.Open();

			using (con)
			{
				string strQuery = "select [A&A PDD Status],[SRQ submitted?], [Blocker], [IT PRODUCT], [wp 4#0] from [dbo].[PDD_Status_Master] where [pdd author] is not null and [pdd author] not in ('IBM GTS', 'TBD') and upper([wp 4#0]) not like upper ('Z-%') and[wp 4#0] not in ('Not Found')";
				SqlCommand cmd = new SqlCommand(strQuery, con);

				SqlDataReader rd = cmd.ExecuteReader();

				while (rd.Read())

				{

					p = new FirstPage();
					p.pdd_status = Convert.ToString(rd.GetSqlValue(0));
					p.SRQStatus = Convert.ToString(rd.GetSqlValue(1));
					p.Blocker = Convert.ToString(rd.GetSqlValue(2));
					p.IT_Product_name = Convert.ToString(rd.GetSqlValue(3));
					AllWaveNos = AllWaveNos + Convert.ToString(rd.GetSqlValue(4));
					FirstPageList.Add(p);

				}
			}
			return FirstPageList;
		}
	}
}
