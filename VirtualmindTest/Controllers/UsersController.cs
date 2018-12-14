using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Http;
using Model;
using Model.Context;

namespace VirtualmindTest.Controllers
{
    public class UsersController : ApiController
    {
        private Context _context;

        public UsersController()
        {
            _context = new Context();
        }

        // GET: api/Users
        public IHttpActionResult Get()
        {
            var users = from u in _context.Users
                        orderby u.LastName
                        select u;

            return Ok(users.ToList());
        }

        // POST: api/Users
        [HttpPost]
        public IHttpActionResult Post(User user)
        {
            _context.Users.Add(user);

            var createdUser = _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + createdUser), user);
        }

        // PUT: api/Users/5
        [HttpPut]
        public IHttpActionResult Put(int id, User user)
        {
            if (user == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            user.Id = id;

            _context.Entry(user).State = EntityState.Modified;

            _context.SaveChanges();

            return Ok(user);
        }

        // DELETE: api/Users/5
        public IHttpActionResult Delete(int id)
        {
            var userInDb = _context.Users.SingleOrDefault(u => u.Id == id);

            if (userInDb == null)
                return NotFound();

            _context.Users.Remove(userInDb);
            _context.SaveChanges();

            return Ok(userInDb);
        }
    }
}
