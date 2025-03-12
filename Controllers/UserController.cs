using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using week1.DTOs;
using week1.Services;

namespace week1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public static List<UserDTO> userData = new List<UserDTO>();

        //Get-Method
        [HttpGet("get-user-details")]
        public IActionResult GetUser()
        {
            var userService = new UserService();
            var result = userService.GetUser();
            return Ok(result);
        }

        //Post-Method
        [HttpPost("add-user-details")]
        public ActionResult<string> AddUser(UserDTO user)
        {
            var userService = new UserService();
            var result =  userService.addUser(user);     
            return Ok(result);
        }

        [HttpPost("upload-image")]
        public IActionResult UploadImage(IFormFile file)
        {          
            return Ok("File Added Successfully.");
        }

        //public List<UserDTO> PostList(UserDTO user)
        //{
        //    userData.Add(user);
        //    return userData;      
        //}
    }
}
