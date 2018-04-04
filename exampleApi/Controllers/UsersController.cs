using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using exampleApi.Models;
using System.Linq;

namespace exampleApi.Controllers
{
	[Route("api/[controller]")]
    public class UsersController : Controller
    {
		private readonly UserContext _context;

        public UsersController(UserContext context)
		{
            
			_context = context;
			
			_context.Users.Add(new User { Name = "Kevin" });
			_context.Users.Add(new User { Name = "Jess" });
			_context.Users.Add(new User { Name = "James" });
			_context.SaveChanges();
			
		}
		// GET: /<controller>/
        [HttpGet]
	    public ActionResult All()
	    {
		    return Json(_context.Users);
	    }
    }
}
