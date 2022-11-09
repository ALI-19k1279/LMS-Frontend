using LMS.DTOS.Users;
using LMS.Models;

namespace LMS.Services.Classes
{
    public interface IClassService
    {
        
        public Task<List<Class>> GetClasses(string tokenvalue);
    }
}
