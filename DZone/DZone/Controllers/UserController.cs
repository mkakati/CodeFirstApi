using DZone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DZone.Controllers
{
    public class UserController : ApiController
    {

        private User[] users = new User[]
        {
            new User { Id = 1, Name = "Mriganga Kakati", Email = "mrigangakakati@gmail.com", Phone = "878946478", Role = 1},
            new User { Id = 2, Name = "Rohan", Email = "kjlfcld@hh.com", Phone = "828766980", Role = 2},
            new User { Id = 3, Name = "Caroline", Email = "jlsdjjmk@hj.com", Phone = "87686755", Role = 1 },
            new User { Id = 4, Name = "Sharma", Email = "jjsdj@jkj.com", Phone = "65785755", Role = 3}
        };
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        
        

    }
}
