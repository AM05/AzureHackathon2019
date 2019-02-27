using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatcHWebMVC.Models
{
    public class IT_PRODUCTS
    {
		// MAI, OAR_ID, IT_PROD_ID , IT_PRODUCT, CIA_RATING, DOMAIN, WP_4_0
		[Key]
		public int ID { get; set; }

		[Display(Name = "APP ID")]
		[StringLength(50, MinimumLength = 3)]
		public string MAI { get; set; }

		[Display(Name = "OAR ID")]
		[StringLength(50, MinimumLength = 3)]
		public string OAR_ID { get; set; }

		[Display(Name = "IT_PRODUCT")]
		public string IT_PRODUCT { get; set; }

		[Display(Name = "CIA RATING")]
		public  Decimal CIA_RATING { get; set; }

		[Display(Name = "DOMAIN")]
		[StringLength(50, MinimumLength = 3)]
		public string DOMAIN { get; set; }

		[Display(Name = "WP 4.0")]
		[StringLength(50, MinimumLength = 3)]
		public string WP_4_0 { get; set; }
		
	}
}
