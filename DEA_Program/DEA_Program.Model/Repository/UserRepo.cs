
namespace DEA_Program.Model.Repository
{
    using DEA_Program.Model.Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class UserRepo : IEnumerable<User>
    {
        private List<User> users;

        public UserRepo()
        {
            this.users = new List<User>();
        }

        public IReadOnlyCollection<User> Users { get => this.users.AsReadOnly(); }


        public void AddUser(User user)
        {
            this.users.Add(user);
        }

        public bool RemoveUser(User user)
        {
            User findUser = GetUser(user.Username);

            if (findUser != null)
            {
                this.users.Remove(user);
                return true;
            }

            return false;
        }

        public User GetUser(string username)
        {
            User findUser = this.users.FirstOrDefault(u => u.Username == username);
            return findUser;

        }

        public bool PersonExist(string username)
        {
            return this.users.Any(u=>u.Username==username);
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach (var user in this.users)
            {
                yield return user;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
