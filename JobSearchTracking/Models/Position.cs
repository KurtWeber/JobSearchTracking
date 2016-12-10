using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSearchTracking.Models
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; }
        public string PositionName { get; set; }
        public string PositionDescription { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public DateTime ResumeSent { get; set; }
        public bool CompanyResponse { get; set; }
        public string ResponseDescription { get; set; }

        [ForeignKey("Interview")]
        public int InterviewID { get; set; }
        public virtual Interview Interview { get; set; }

    }
}