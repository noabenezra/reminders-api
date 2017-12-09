using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{



    //[Authorize]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(string title, string description,DateTime dueDate)
        {
            var newReminder = new Reminder();
            newReminder.Title = title;
            newReminder.DueDate = dueDate;
            newReminder.Description = description;
            using (var db = new RemindersEntities())
            {                            
                db.Reminders.Add(newReminder);
                db.SaveChanges();
            }
            return "ok";    
        }

        // POST api/values
        public void Post(string title, string description, DateTime dueDate)
        {
            var newReminder = new Reminder();
            newReminder.Title = title;
            newReminder.DueDate = dueDate;
            newReminder.Description = description;
            using (var db = new RemindersEntities())
            {
                db.Reminders.Add(newReminder);
                db.SaveChanges();
            }
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
