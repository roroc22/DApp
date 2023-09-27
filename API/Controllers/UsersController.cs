using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]

    //UsersController: BaseApiController 繼承自BaseApiController 的意思
    public class UsersController: BaseApiController 
    {
        
        private readonly DataContext _context;

        public UsersController(DataContext context){
            _context = context;
        }
        [AllowAnonymous]
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
}
