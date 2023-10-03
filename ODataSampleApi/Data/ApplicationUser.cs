using Microsoft.AspNetCore.Identity;

namespace ODataSampleApi.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
