using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Entity;
		

namespace WCFMatcHDAL
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
	public class ITProductService : IITProductService
	{

		public ITProduct GetITProduct(string id)
		{
			// TODO: retrieve the real product info from DB using EF
			ITProduct product = new ITProduct();
			product.MAI = id;
			product.OAR_ID = "APP001";
			product.IT_PRODUCT = "CYBERARC";
			product.DOMAIN = "CISO";
			product.WP_4_0 = "WP-25";
			return product;
		}
		
		
	}
}
