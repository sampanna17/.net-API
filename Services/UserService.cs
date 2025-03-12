using Microsoft.AspNetCore.Mvc;
using week1.DTOs;

namespace week1.Services
{
    public class UserService
    {
        public static List<UserDTO> userData = new List<UserDTO>();
  
        public string addUser(UserDTO user)
        {
            userData.Add(user);
            return "User Added Successfully.";
        }

        public List<UserDTO> GetUser()
        {
            return userData;
        }
    }
}
