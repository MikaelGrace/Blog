using Blog.DAO;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.X509.Qualified;
using System.Net;

namespace Blog.Controllers
{
    public class UserController : ControllerBase
    {
        [HttpPost ("AddNew")]
        public ActionResult<User> AddNew([FromBody]User user)
        {
            var userDao = new UserDao();
            var addedUser = userDao.Add(user);
            return StatusCode((int)HttpStatusCode.OK,addedUser);
        }
    }
}
