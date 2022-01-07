using MultipleChoiceSite.Common;
using MultipleChoiceSite.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Services;

namespace MultipleChoiceSite.Services
{
    /// <summary>
    /// Summary description for SubjectApiService
    /// </summary>
    [WebService(Namespace = Constant.ServiceNameSpace + "/SubjectApi")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SubjectApiService : System.Web.Services.WebService
    {

        String URI = "https://bsite.net/chimlacapi/api/subjects";


        [WebMethod]
        public List<Subject> searchByKeyword(String keyword)
        {
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            String response = client.DownloadString(URI + $"/search/{keyword}");
            List<Subject> items = JsonConvert.DeserializeObject<List<Subject>>(response);
            return items;
        }
        [WebMethod]

        public List<Subject> getAvailableForExam(DateTime d, int studentId)
        {
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            String response = client.DownloadString(URI + $"/get-available-for-exam/{studentId}?date={d}");
            List<Subject> items = JsonConvert.DeserializeObject<List<Subject>>(response);
            return items;
        }

        [WebMethod]
        public List<Subject> getAllForSelectData()
        {
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            String response = client.DownloadString(URI + $"/get-all-for-select-data");
            List<Subject> items = JsonConvert.DeserializeObject<List<Subject>>(response);
            return items;
        }
        [WebMethod]
        public List<Subject> getAll(int itemsPerPage, int currentPage)
        {
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            String response = client.DownloadString(URI + $"/get-all/{itemsPerPage}/{currentPage}");
            List<Subject> items = JsonConvert.DeserializeObject<List<Subject>>(response);
            return items;
        }
        [WebMethod]
        public int countAll()
        {
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            String response = client.DownloadString(URI + $"/count-all");
            int result = JsonConvert.DeserializeObject<int>(response);
            return result;
        }
        [WebMethod]
        public Subject getDetailsById(int id)
        {
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            String response = client.DownloadString(URI + $"/{id}");
            Subject item = JsonConvert.DeserializeObject<Subject>(response);
            return item;
        }

        [WebMethod]
        public bool add(Subject item)
        {
            String data = JsonConvert.SerializeObject(item);
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI, "POST", data);
            bool result = bool.Parse(response);
            return result;
        }
        [WebMethod]
        public virtual int addMany(List<Subject> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (add(item)) count++;
            }
            return count;
        }

        [WebMethod]
        public bool update(Subject item)
        {
            String data = JsonConvert.SerializeObject(item);
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            String response = client.UploadString(URI + $"/{item.Id}", "PUT", data);
            bool result = bool.Parse(response);
            return result;
        }

        [WebMethod]
        public virtual bool delete(int id)
        {
            WebClient client = new WebClient() { 
                Encoding = Encoding.UTF8
            };
            String response = client.UploadString(URI + $"/{id}", "DELETE", "");
            bool result = bool.Parse(response);
            return result;
        }


    }
}
