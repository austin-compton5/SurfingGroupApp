using surfgroupfinder.Data;
using Microsoft.AspNetCore.Mvc;
using surfgroupfinder.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace surfgroupfinder.Controllers{

    [ApiController]
    [Route("api/[controller]")]

    public class SurfUsersController : ControllerBase {
        
        private readonly DataContext _context;
        public SurfUsersController(DataContext context){
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<AppUser>>>GetUsers(){

            return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<AppUser>>GetUser(int id){

            return await _context.Users.FindAsync(id);
        }

    }
}