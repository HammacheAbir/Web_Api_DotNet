using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;
using Web_Api_DotNet.Models;

namespace Web_Api_DotNet.Controllers
{
    public class PeopleController : ApiController
    {

        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName="Abir", LastName = "Hammache", id= 1});
            people.Add(new Person { FirstName = "Alaeddine", LastName = "Hammache", id = 2 });
            people.Add (new Person { FirstName = "Dhiaeddine", LastName = "Hammache", id = 3});
        }


        [Route ("api/People/GetFirstNames")]
        [HttpGet]
        public List<string> GetFirstNames()
        {
            List<string> outPuts = new List<string>();

            foreach (Person p in people)
            {
                outPuts.Add(p.FirstName);
            }

            return outPuts;

        }



        public List<Person> Get()
        {

            return people;
           
        }

        public Person Get(int id)
        {
            return people.Where(x => x.id == id).FirstOrDefault();
        }

        public void Post([FromBody]Person p)
        {
            people.Add(p);
           
        }

        public void Delete(int id)
        {

        }

    }
}