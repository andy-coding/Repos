using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpdesk_API_Integration.Models
{
    public class Urgency
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public bool ISDELETED { get; set; }
        public string DESCRIPTION { get; set; }
    }
}