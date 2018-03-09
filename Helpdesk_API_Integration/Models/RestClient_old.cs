using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Helpdesk_API_Integration.Models
{
    public enum httpverb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class RestClient_old
    {
        public string endPoint{ get; set; }
        public httpverb httpMethod { get; set; }


        public RestClient_old()
        {
            endPoint = "http://itildemo.servicedeskplus.com";
            httpMethod = httpverb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.ToString());
                }
                //Process the response stream (could be JSON, XML or HTML etc)

            using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }//end of StreamReader
                    }
                } // end of using responseStream


            }

                return strResponseValue;
        }

    }


}