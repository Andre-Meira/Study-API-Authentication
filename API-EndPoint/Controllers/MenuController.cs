using API_EndPoint.Models.Config_Migration;
using API_EndPoint.Models.Entities;
using BasicAuthenticationa;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_EndPoint.Controllers
{
  
    [ApiController]
    [Route("system/api")]    
    public class MenuController : ControllerBase
    {        
        private ContextRestaurant _context;
        private BasicAuthentication _auth;               

        public MenuController(ContextRestaurant context, BasicAuthentication auth)
        {
            _context = context;
            _auth = auth;            
        }
        
        [HttpGet]                
        public async Task<ActionResult<IEnumerable<MenuRestaurant>>> GetIMenu([FromHeader] string Authorization)            
        {            
            if (_auth.OnAuthorization(Authorization))
            {
                return await _context.MenuRestaurants.ToListAsync();
            }
            
            return BadRequest("User dont having permission!!");
        }

        [HttpPost]
        [Route("UpdateMenu")]
        public async Task<ActionResult> AddMenu([FromBody] MenuRestaurant body,
            [FromHeader] string Authorization) 
        {
            if (_auth.OnAuthorization(Authorization))
            {
                _context.MenuRestaurants.Add(body);
                await _context.SaveChangesAsync();
                return Ok("menu successfully added!!");
            }
            return BadRequest();
        }

        [HttpPost]
        [Route("RemoveMenu")]        
        public async Task<ActionResult> RemoveMenu([FromBody] MenuRestaurant body,
            [FromHeader] string Authorization) 
        {
            if (_auth.OnAuthorization(Authorization))
            {
                _context.MenuRestaurants.Remove(body);
                await _context.SaveChangesAsync();
                return Ok("menu successfully remove!!");
            }
            return BadRequest();
        }
    }
}
