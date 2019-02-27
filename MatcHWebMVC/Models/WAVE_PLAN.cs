using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatcHWebMVC.Models
{
    public class WAVE_PLAN
    {
		// Wave_Plan_ID, MAI, WP_4_0, OAR_ID, IT_PRODUCT, DOMAIN, IT_DELIVERY_DOMAIN, IT_PROD_ID, BAU_AD_VENDOR, MATCH_VENDOR, CI_Count, CIA_Rating
		[Key]
		public int Wave_Plan_ID { get; set; }

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
		
		
		[Display(Name = "IT DELIVERY DOMAIN")]
		[StringLength(50, MinimumLength = 3)]
		public string IT_DELIVERY_DOMAIN { get; set; }
	
		[Display(Name = "IT PROD ID")]
		public  Decimal IT_PROD_ID { get; set; }
		
		[Display(Name = "BAU AD VENDOR")]
		[StringLength(50, MinimumLength = 3)]
		public string BAU_AD_VENDOR { get; set; }
		
		[Display(Name = "MATCH VENDOR")]
		[StringLength(50, MinimumLength = 3)]
		public string MATCH_VENDOR { get; set; }
		
		
	}
}
