using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobSearchTracking.Models
{
    public class Interview
    {
        [Key]
        public int InterviewID { get; set; }
        public DateTime IntervireDate { get; set; }
        public string InterviewOutcome { get; set; }
    }
}