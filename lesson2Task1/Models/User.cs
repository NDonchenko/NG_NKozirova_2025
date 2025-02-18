namespace Lesson2Task1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; } = "";
        public string Password { get; set; } = "";
        public bool IsAdmin { get; set; }

        public static List<User> Users = new List<User>
        {
            new User { Id = 1, UserName = "Admin", Password = "admin1", IsAdmin = true},
            new User { Id = 2, UserName = "Natali", Password = "Natali2", IsAdmin = false},
            new User { Id = 3, UserName = "Jora", Password = "Jora3", IsAdmin = false}
        };
       
    }
}
