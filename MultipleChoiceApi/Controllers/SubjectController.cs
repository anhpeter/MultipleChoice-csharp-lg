using MultipleChoiceApi.DTO;
using MultipleChoiceApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace MultipleChoiceApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SubjectController : ApiController
    {
        SubjectDAO mainDAO = new SubjectDAO();

        [HttpGet]
        [Route("api/subjects/get-available-for-exam/{studentId}")]
        public List<Subject> getAvailableForExam(int studentId)
        {
            var allUrlKeyValues = ControllerContext.Request.GetQueryNameValuePairs();
            string dateStr = allUrlKeyValues.LastOrDefault(x => x.Key == "date").Value;
            DateTime date = Convert.ToDateTime(dateStr);
            return mainDAO.getAvailableForExam(date, studentId);
        }
        [HttpGet]
        [Route("api/subjects/search/{keyword}")]
        public List<Subject> searchByKeyword(String keyword)
        {
            return mainDAO.searchByKeyWord(keyword);
        }

        //FETCHES
        [HttpGet]
        [Route("api/subjects/get-all-for-select-data")]
        public List<Subject> getAllForSelectData()
        {
            return mainDAO.getAllForSelectData();
        }
        [HttpGet]
        [Route("api/subjects/get-all/{itemsPerPage}/{currentPage}")]
        public List<Subject> getAll(int itemsPerPage, int currentPage)
        {
            return mainDAO.getAll(itemsPerPage, currentPage);
        }
        [HttpGet]
        [Route("api/subjects/count-all")]
        public int countAll()
        {
            return mainDAO.countAll();
        }
        [HttpGet]
        [Route("api/subjects/{id}")]
        public Subject getDetailsById(int id)
        {
            Subject item = mainDAO.getByPK(id + "");
            return item;
        }
        //WRITE
        [HttpPost]
        [Route("api/subjects")]
        public bool add(Subject item)
        {
            return mainDAO.add(item) > 0;
        }
        [HttpPost]
        [Route("api/subjects/add-many")]
        public int addMany(List<Subject> list)
        {
            int count = 0;
            foreach (var item in list)
            {
                if (add(item)) count++;
            }
            return count;
        }
        [HttpPut]
        [Route("api/subjects/{id}")]
        public bool update(int id, Subject item)
        {

            if (id != item.Id) return false;
            return mainDAO.update(item);
        }

        [HttpDelete]
        [Route("api/subjects/{id}")]
        public bool delete(int id)
        {
            return mainDAO.deleteByPK(id + "");
        }



        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<controller>
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}
    }
}