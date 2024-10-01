

using Microsoft.AspNetCore.Mvc;
using API.Entities;
using API.Data;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers;


[ApiController]
[Route("api/[controller]")] // /api/users
public class UsersController(DataContext context) : ControllerBase
{
    

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
        
        var users = await context.Users.ToListAsync();


        return users;
    }
    [HttpGet("{id:int}")] // /api/users/3
    public async Task<ActionResult<AppUser>> GetUsers(int id){
        
        var user = await context.Users.FindAsync(id);
        
        if (user == null) return NotFound();

        return user;
    }

}
