using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatcHWebMVC.Models
{
    public class DCL3		
    {
		[Key]
		public int DCL3ID { get; set; }

		[Display(Name = "APP ID")]
		[StringLength(50, MinimumLength = 3)]
		public string MAI { get; set; }

		[Display(Name = "Wave NO")]
		[StringLength(50, MinimumLength = 3)]
		public string Wave { get; set; }

		[Display(Name = "DOMAIN")]
		[StringLength(50, MinimumLength = 3)]
		public string DOMAIN { get; set; }

		[Display(Name = "IT GRID")]
		[StringLength(50, MinimumLength = 3)]
		public string IT_GRID { get; set; }

		[Display(Name = "OAR ID")]
		[StringLength(50, MinimumLength = 3)]
		public string OAR_ID { get; set; }

		[Display(Name = "PRODUCT ID")]
		public double PRODUCT_ID { get; set; }

		[Display(Name = "IT PRODUCT")]
		[StringLength(50, MinimumLength = 3)]
		public string IT_PRODUCT { get; set; }

		[Display(Name = "MATCH IT PRODUCT")]
		[StringLength(50, MinimumLength = 3)]
		public string MATCH_ITPRODUCT { get; set; }

		[Display(Name = "MATCH VENDOR")]
		[StringLength(50, MinimumLength = 3)]
		public string MATCH_VENDOR { get; set; }

	}
}
