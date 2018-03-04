using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpdesk_API_Integration.Models
{
    public class Status
    {
        public int ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public bool ISPENDING { get; set; }
        public bool STOPCLOCK { get; set; }
        public bool ISDELETED { get; set; }
    }
}