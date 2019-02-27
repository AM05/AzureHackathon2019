using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFMatcHDAL
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IITProductService
	{
		[OperationContract]
		// string GetData(int value);
		ITProduct GetITProduct(string id);
		
		// TODO: Add your service operations here
	}

	// Use a data contract as illustrated in the sample below to add composite types to service operations.
	// You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WCFMatcHDAL.ContractType".
	[DataContract]
	public class ITProduct
	{
		[DataMember]
		public string MAI { get; set; }
		[DataMember]
		public string OAR_ID { get; set; }
		[DataMember]
		public string IT_PRODUCT { get; set; }
		[DataMember]
		public string DOMAIN { get; set; }
		[DataMember]
		public string WP_4_0 { get; set; }
	}
}
