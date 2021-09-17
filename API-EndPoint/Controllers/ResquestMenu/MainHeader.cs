using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace API_EndPoint.Controllers.ResquestMenu
{
    public class MainHeader
    {
        [FromHeader]
        [Required(ErrorMessage = "Username is Required!!")]
        public string UserName { get; set; }

        [FromHeader]
        [Required(ErrorMessage = "PassWord is Required!!")]
        public string Password { get; set; }
    }
}
