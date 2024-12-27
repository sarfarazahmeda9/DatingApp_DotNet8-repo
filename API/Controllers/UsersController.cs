using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(DataContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await context.Users.ToListAsync();
            return users;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            var user = await context.Users.FindAsync(id);

            if(user == null)
            {
                return NotFound();
            }

            return user;
        }

        // [HttpPost]
        // public ActionResult<string> AddUser()
        // {
        //     return "Add User";
        // }

        // [HttpPut("{id}")]
        // public ActionResult<string> UpdateUser(int id)
        // {
        //     return "Update User " + id;
        // }

        // [HttpDelete("{id}")]
        // public ActionResult<string> DeleteUser(int id)
        // {
        //     return "Delete User " + id;
        // }


    }
}
