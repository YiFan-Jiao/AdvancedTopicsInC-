using IntroToUsers.Controllers;

namespace IntroToUsers.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Deposit { get; set; }


        public string DemoUserID { get; set; }
        public DemoUser DemoUser { get; set; }
        


    }
}
