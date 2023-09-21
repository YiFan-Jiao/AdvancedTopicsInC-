using Microsoft.AspNetCore.Identity;

namespace IntroToUsers.Models
{
    public class DemoUser : IdentityUser
    {
        public HashSet<Account> Accounts { get; set; } = new HashSet<Account>();
        public int Age { get; set; }
    }
}
