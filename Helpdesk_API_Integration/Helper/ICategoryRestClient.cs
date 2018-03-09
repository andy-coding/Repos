using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helpdesk_API_Integration.Models;

namespace Helpdesk_API_Integration.Helper
{
    public interface ICategoryRestClient
    {
        //void Add(ServerDataModel serverDataModel);
        //void Delete(int id);
        IEnumerable<Category> GetAll();
        //string GetAll(); 
        Category GetById(int id);
        //ServerDataModel GetByIP(int ip);
        //ServerDataModel GetByType(int type);
        //void Update(ServerDataModel serverDataModel);
    }
}
