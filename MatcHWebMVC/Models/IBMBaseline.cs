using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatcHWebMVCC.Models
{
    public class IBMBaseline
    {
		[Key]
		public int BASELINEID { get; set; }

		[Display(Name = "APP ID")]
		[StringLength(50, MinimumLength = 3)]
		public string MAI { get; set; }

		[Display(Name = "RP CI Name")]
		[StringLength(50, MinimumLength = 3)]
		public string RP_CI_Name { get; set; }
		
		[Display(Name = "RP Environment")]
		[StringLength(50, MinimumLength = 3)]
		public string RP_Environment { get; set; }

		[Display(Name = "PLATFORM")]
		[StringLength(50, MinimumLength = 3)]
		public string PLATFORM { get; set; }

		[Display(Name = "VERSION")]
		[StringLength(50, MinimumLength = 3)]
		public string VERSION { get; set; }
		
		[Display(Name = "OAR-ID")]
		[StringLength(50, MinimumLength = 3)]
		public string OAR_ID { get; set; }

		[Display(Name = "DOMAIN IT PRODUCT")]
		[StringLength(50, MinimumLength = 3)]
		public string DOMAIN_IT_PRODUCT { get; set; }

		[Display(Name = "DOMAIN OAR")]
		[StringLength(50, MinimumLength = 3)]
		public string DOMAIN_OAR { get; set; }

		[Display(Name = "SUB-DOMAIN")]
		[StringLength(50, MinimumLength = 3)]
		public string SUB_DOMAIN { get; set; }
		
		[Display(Name = "ADM VENDOR")]
		[StringLength(50, MinimumLength = 3)]
		public string ADM_VENDOR { get; set; }
		
		[Display(Name = "MAINT VENDOR")]
		[StringLength(50, MinimumLength = 3)]
		public string MAINT_VENDOR { get; set; }
		
		[Display(Name = "IT-PRODUCT-ID")]
		[StringLength(50, MinimumLength = 3)]
		public string IT_PRODUCT_ID { get; set; }
		
		[Display(Name = "IT PRODUCT")]
		[StringLength(50, MinimumLength = 3)]
		public string IT_PRODUCT { get; set; }
		
		[Display(Name = "IT BUSINESS SERVICE")]
		[StringLength(50, MinimumLength = 3)]
		public string IT_BUSINESS_SERVICE { get; set; }

		[Display(Name = "CIA RATING IT PRODUCT")]
		[StringLength(50, MinimumLength = 3)]
		public string CIA_RATING_IT_PRODUCT { get; set; }

		[Display(Name = "CIA RATING OAR float")]
		[StringLength(50, MinimumLength = 3)]
		public string CIA_RATING_OAR  { get; set; }

		[Display(Name = "RP_CI_STATUS")]
		[StringLength(50, MinimumLength = 3)]
		public string RP_CI_STATUS { get; set; }

		[Display(Name = "PLANNING")]
		[StringLength(50, MinimumLength = 3)]
		public string PLANNING { get; set; }

		[Display(Name = "ACTION")]
		[StringLength(50, MinimumLength = 3)]
		public string ACTION { get; set; }

		[Display(Name = "SUB-ACTION")]
		[StringLength(50, MinimumLength = 3)]
		public string SUB_ACTION { get; set; }

		[Display(Name = "MATCH WAVE")]
		[StringLength(50, MinimumLength = 3)]
		public string MATCH_WAVE { get; set; }
		
		[Display(Name = "MATCH DATE")]
		[StringLength(50, MinimumLength = 3)]
		public string MATCH_DATE { get; set; }
		
		[Display(Name = "MATCH PHASE")]
		[StringLength(50, MinimumLength = 3)]
		public string MATCH_PHASE { get; set; }
		
		[Display(Name = "CLEAN SOURCE")]
		[StringLength(50, MinimumLength = 3)]
		public string CLEAN_SOURCE { get; set; }
		
		[Display(Name = "CLEAN DATE")]
		[StringLength(50, MinimumLength = 3)]
		public string CLEAN_DATE { get; set; }
		
		[Display(Name = "CLEAN PHASE")]
		[StringLength(50, MinimumLength = 3)]
		public string CLEAN_PHASE { get; set; }
		
		[Display(Name = "CLEAN ID")]
		[StringLength(50, MinimumLength = 3)]
		public string CLEAN_ID { get; set; }
		
		[Display(Name = "HISTORY")]
		[StringLength(50, MinimumLength = 3)]
		public string HISTORY { get; set; }

		[Display(Name = "STATUS IT PRODUCT")]
		[StringLength(50, MinimumLength = 3)]
		public string STATUS_IT_PRODUCT { get; set; }

		[Display(Name = "PRIMARY CI NAME")]
		[StringLength(50, MinimumLength = 3)]
		public string PRIMARY_CI_NAME { get; set; }

		[Display(Name = "ADDRESS OF CI")]
		[StringLength(50, MinimumLength = 3)]
		public string ADDRESS_OF_CI { get; set; }

		[Display(Name = "LOGICAL CI AD DOMAIN")]
		[StringLength(50, MinimumLength = 3)]
		public string LOGICAL_CI_AD_DOMAIN { get; set; }

		[Display(Name = "IP ADDRESS")]
		[StringLength(50, MinimumLength = 3)]
		public string IP_ADDRESS { get; set; }

		[Display(Name = "MATCH VENDOR")]
		[StringLength(50, MinimumLength = 3)]
		public string MATCH_VENDOR { get; set; }

		[Display(Name = "CIA")]
		[StringLength(50, MinimumLength = 3)]
		public string CIA { get; set; }

		[Display(Name = "PHYSICAL SERVER NAME")]
		[StringLength(50, MinimumLength = 3)]
		public string PHYSICAL_SERVER_NAME { get; set; }

		[Display(Name = "PHYSICAL CI NAME")]
		[StringLength(50, MinimumLength = 3)]
		public string PHYSICAL_CI_NAME { get; set; }

		[Display(Name = "BUSINESS SERVICE")]
		[StringLength(50, MinimumLength = 3)]
		public string BUSINESS_SERVICE { get; set; }

		
	}
}
