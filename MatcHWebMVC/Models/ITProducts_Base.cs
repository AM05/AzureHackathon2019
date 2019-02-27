using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MatcHWebMVCC.Models
{
	public interface iITProducts_Base
	{
		 int ID { get; set; }
		 string MAI { get; set; }
		 string OAR_ID { get; set; }
		 string IT_PRODUCT { get; set; }
		 string DOMAIN { get; set; }
		 string WP_4_0 { get; set; }
	}

    public abstract class ITProducts_Base: iITProducts_Base
	{
		public int caID;
		public string caMAI;
		public string caOAR_ID;
		public string caIT_PRODUCT;
		public string caDOMAIN;
		public string caWP_4_0;

		public int ID
		{
			get { return this.caID; }
			set { this.caID = value; }

		}

		public string MAI
		{
			get { return this.caMAI; }
			set { this.caMAI = value; }

		}

		public string OAR_ID
		{
			get { return this.caOAR_ID; }
			set { this.caOAR_ID = value; }

		}

		public string IT_PRODUCT
		{
			get { return this.caIT_PRODUCT; }
			set { this.caIT_PRODUCT = value; }

		}

		public string DOMAIN
		{
			get { return this.caDOMAIN; }
			set { this.caDOMAIN = value; }

		}

		public string WP_4_0
		{
			get { return this.caWP_4_0; }
			set { this.caWP_4_0 = value; }


		}
		public string IT_PROD_Details_WP
		{
			get
			{
				return caMAI + " , " + caOAR_ID + " , " + caIT_PRODUCT + " , " + caDOMAIN + " , " + caWP_4_0;
			}
		}

		public abstract string CheckITProductWP_4(string lcMAI, string lcOAR_ID, string lcITProduct, string lcDomin, string lcWP_4_0);

	}

	public class ITPROD_Wave_Plan : ITProducts_Base
	{
		public override string CheckITProductWP_4(string lcMAI, string lcOAR_ID, string lcITProduct, string lcDomin, string lcWP_4_0)
		{
		
			return "True";
		}
	}

}
