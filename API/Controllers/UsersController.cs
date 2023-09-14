using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]//step1. When an Http request comes in, it's going to be
//routed to this controller.

//step2. The framework's going to see our user's controller and see the constructor
public class UsersController: ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context){
        _context = context;
    }
    [HttpGet]//api/user
    public async Task<ActionResult<IEnumerable<AppUser>>>GetUsers(){
        var users = await _context.Users.ToListAsync();
        return users;
    }

    [HttpGet("{id}")]//指定要查找的用戶//api/users/2
    public async Task<ActionResult<AppUser>> GetUser(int id){
        return  await _context.Users.FindAsync(id);
        
    }
}
