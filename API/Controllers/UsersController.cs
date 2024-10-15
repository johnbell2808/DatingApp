using Microsoft.AspNetCore.Mvc;
using API.Entities;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers;


[Authorize]
public class UsersController(DataContext context) : BaseApiController
{
    
    [AllowAnonymous]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){
        
        var users = await context.Users.ToListAsync();


        return users;
    }
    [Authorize]
    [HttpGet("{id:int}")] // /api/users/3
    public async Task<ActionResult<AppUser>> GetUsers(int id){
        
        var user = await context.Users.FindAsync(id);
        
        if (user == null) return NotFound();

        return user;
    }

}
