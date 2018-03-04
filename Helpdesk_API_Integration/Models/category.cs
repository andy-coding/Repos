using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Helpdesk_API_Integration.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<category> GetAll();
        category Get(int ID);
        //void Create(category category);
        //void Update(int ID, category category);
        //void Delete(int ID);
    }

    public class category
    {
        private bool _iSDELETED;

        public int ID { get; set; }
        public string NAME { get; set; }
        public bool ISDELETED { get => _iSDELETED; set => _iSDELETED = value; }
        public string DESCRIPTION { get; set; }
    }
}