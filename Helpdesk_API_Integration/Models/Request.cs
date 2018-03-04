using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helpdesk_API_Integration.Models
{
    public class Request
    {
        public string WORKORDERID { get; set; }
        public string REQUESTER { get; set; }
        public string CREATEDBY { get; set; }
        public string CREATEDTIME { get; set; }
        public string DUEBYTIME { get; set; }
        public string RESPONSEDUEBYTIME { get; set; }
        public string FR_DUETIME { get; set; }
        public string RESPONDEDTIME { get; set; }
        public string RESOLVEDTIME { get; set; }
        public string COMPLETEDTIME { get; set; }
        public string SHORTDESCRIPTION { get; set; }
        public string TIMESPENTONREQ { get; set; }
        public string SUBJECT { get; set; }
        public string REQUESTTEMPLATE { get; set; }
        public string MODE { get; set; }
        public string SLA { get; set; }
        public string ASSET { get; set; }
        public string DEPARTMENT { get; set; }
        public string IS_CATALOG_TEMPLATE { get; set; }
        public string SITE { get; set; }
        public string ISVIPUSER { get; set; }
        public string SERVICE { get; set; }
        public string CATEGORY { get; set; }
        public string SUBCATEGORY { get; set; }
        public string ITEM { get; set; }
        public string TECHNICIAN { get; set; }
        public string TECHNICIAN_LOGINNAME { get; set; }
        public string STATUS { get; set; }
        public string PRIORITY { get; set; }
        public string LEVEL { get; set; }
        public string IMPACT { get; set; }
        public string URGENCY { get; set; }
        public string IMPACTDETAILS { get; set; }
        public string REQUESTTYPE { get; set; }
        public string CLOSURECODE { get; set; }
        public string CLOSURECOMMENTS { get; set; }
        public string YETTOREPLYCOUNT { get; set; }
        public string GROUP { get; set; }
        public string DESCRIPTION { get; set; }
    }
}