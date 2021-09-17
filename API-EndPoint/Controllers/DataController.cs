using API_EndPoint.Controllers.ResquestMenu;
using API_EndPoint.Models.Config_Migration;
using API_EndPoint.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_EndPoint.Controllers
{
  
    [ApiController]
    [Route("system/api")]    
    public class DataController : ControllerBase
    {
        private ContextRestaurant _context;
        public DataController(ContextRestaurant context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuRestaurant>>> GetIMenu(
            [FromHeader] MainHeader header)
        {
            if (VerficUser(header))
            {
                return await _context.MenuRestaurants.ToListAsync();
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<ActionResult<MenuRestaurant>> AddMenu([FromHeader] MainHeader header
            ,[FromBody] MenuRestaurant body) 
        {
            if (VerficUser(header))
            {
                 _context.MenuRestaurants.Add(body);
                await _context.SaveChangesAsync();
                return Ok("menu successfully added!! ");
            }
            return BadRequest();
        }

        private bool VerficUser(MainHeader header)
        {
            if (header.UserName == "teste" && header.Password == "123")
                return true;            

            return false;
        }
    }
}
