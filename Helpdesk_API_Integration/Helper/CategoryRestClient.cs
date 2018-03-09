using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using Helpdesk_API_Integration.Models;
using System.Net;
using System.Configuration;


namespace Helpdesk_API_Integration.Helper
{
    public class CategoryRestClient : ICategoryRestClient
    {
        private readonly RestClient _client;
        private readonly string _url = "http://itildemo.servicedeskplus.com";

        public CategoryRestClient()
        {
            _client = new RestClient();
            _client.BaseUrl = new System.Uri(_url);
        }

        public IEnumerable<Category> GetAll()
        {
            var request = new RestRequest("sdpapi/admin/category", Method.GET) { RequestFormat = DataFormat.Json };
            request.AddQueryParameter("OPERATION_NAME", "GET_ALL");
            request.AddQueryParameter("TECHNICIAN_KEY", "1A8DC1F2-8C1F-4500-95FE-245AEFCBB1F2");

            var response = _client.Execute<List<Category>>(request);

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            //var debugcats = new List<Category>();
            //var cat1 = new Category { id = 1, name = "Dave"  };
            //var cat2 = new Category { id = 2, name = "Charlie" };
            //debugcats.Add(cat1);
            //debugcats.Add(cat2);

            return response.Data;
        }



        public Category GetById(int id)
        {
            var request = new RestRequest("sdpapi/admin/{id}", Method.GET) { RequestFormat = DataFormat.Json };

            request.AddParameter("id", id, ParameterType.UrlSegment);
            request.AddParameter("OPERATION_NAME", "GET");
            request.AddParameter("TECHNICIAN_KEY", "1A8DC1F2-8C1F-4500-95FE-245AEFCBB1F2");

            var response = _client.Execute<Category>(request);

            debugOutput(request.ToString());

            if (response.Data == null)
                throw new Exception(response.ErrorMessage);

            return response.Data;
        }

        public Category GetByType(int type)
        {
            var request = new RestRequest("sdpapi/admin/{datatype}", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };

            request.AddParameter("datatype", type, ParameterType.UrlSegment);

            var response = _client.Execute<Category>(request);

            return response.Data;
        }

        public void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message + Environment.NewLine);
            }

        }



        //public ServerDataModel GetByIP(int ip)
        //{
        //    var request = new RestRequest
        //    ("api/serverdata/ip/{ip}", Method.GET)
        //    { RequestFormat = DataFormat.Json };
        //    request.AddParameter("ip", ip, ParameterType.UrlSegment);

        //    var response = _client.Execute<ServerDataModel>(request);

        //    return response.Data;
        //}

        //public void Add(ServerDataModel serverData)
        //{
        //    var request = new RestRequest
        //    ("api/serverdata", Method.POST)
        //    { RequestFormat = DataFormat.Json };
        //    request.AddBody(serverData);

        //    var response = _client.Execute<ServerDataModel>(request);

        //    if (response.StatusCode != HttpStatusCode.Created)
        //        throw new Exception(response.ErrorMessage);
        //}

        //public void Update(ServerDataModel serverData)
        //{
        //    var request = new RestRequest
        //    ("api/serverdata/{id}", Method.PUT)
        //    { RequestFormat = DataFormat.Json };
        //    request.AddParameter("id", serverData.ID, ParameterType.UrlSegment);
        //    request.AddBody(serverData);

        //    var response = _client.Execute<ServerDataModel>(request);

        //    if (response.StatusCode == HttpStatusCode.NotFound)
        //        throw new Exception(response.ErrorMessage);
        //}

        //public void Delete(int id)
        //{
        //    var request = new RestRequest("api/serverdata/{id}", Method.DELETE);
        //    request.AddParameter("id", id, ParameterType.UrlSegment);

        //    var response = _client.Execute<ServerDataModel>(request);

        //    if (response.StatusCode == HttpStatusCode.NotFound)
        //        throw new Exception(response.ErrorMessage);
        //}

        //IEnumerable<ServerDataModel> IServerDataRestClient.GetAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}