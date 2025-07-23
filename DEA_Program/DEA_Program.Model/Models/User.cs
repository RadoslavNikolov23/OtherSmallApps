namespace DEA_Program.Model.Models
{
    using DEA_Program.Common.Enums;

    public class User
    {
        public User(string username, string password, Role role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
        }

        public string Username { get; set; }

        public string Password { get; set; }

        public Role Role { get; set; }
    }
}
