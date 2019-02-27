namespace WCFMatcHDAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wave_Plan
    {
        [Key]
        public int Wave_Plan_ID { get; set; }

        public string ADV_Health { get; set; }

        public string Assigned_Domain { get; set; }

        public string Assigned_ITDDM { get; set; }

        public string BAU_AD_VENDOR { get; set; }

        public decimal? CIA_Rating { get; set; }

        public decimal? CI_Count { get; set; }

        public string Category { get; set; }

        public string DOMAIN { get; set; }

        public string Go_Live_on_CMS { get; set; }

        public string Grouping { get; set; }

        public string IT_DELIVERY_DOMAIN { get; set; }

        public string IT_GRID { get; set; }

        public string IT_PRODUCT { get; set; }

        public decimal? IT_PROD_ID { get; set; }

        public string MAI { get; set; }

        public string MATCH_VENDOR { get; set; }

        public string OAR_ID { get; set; }

        public decimal? Phase { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Planned_GLV { get; set; }

        public string SUB_DOMAIN { get; set; }

        public string WAVE_Before_WP2_0 { get; set; }

        public string WAVE_Changes_After_WP2_0 { get; set; }

        public string WP30_Base { get; set; }

        public string WP_2_0_5 { get; set; }

        public string WP_2_0_5_Base { get; set; }

        public string WP_2_0_old_tag { get; set; }

        public string WP_4_0 { get; set; }

        public string WP_4_0_Grouping { get; set; }

        public string Rating { get; set; }
    }
}
