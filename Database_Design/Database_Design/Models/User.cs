using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_Design.Models
{
	public class User
	{
        public String UserName { get; set; }
        public String Password { get; set; }
    }
    public class UserDatabase : List<User>
    {
        public UserDatabase()
        {
            Add(new User() { UserName = "Test1", Password = "Test1" });
            Add(new User() { UserName = "Test2", Password = "Test2" });
        }
    }
}
