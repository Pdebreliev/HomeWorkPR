using Microsoft.Azure.Documents;

namespace Start.LINQ
{
    public class BasicLINQ
    {
        public void QueryExample()
        {
            var users = new List<Users>
           {
            GetDefaultUsers(),
            GetDefaultDumbDumb(),
            GetDefaultBot()
           };

            foreach (var user in users)
            {
                if (user.Name.Equals("Plamen"))
                {
                    Console.WriteLine($"{user.Name} {user.Age}");
                }
            }
            var filteredUser = users.Where(users => users.Name.Equals("Plamen") && users.Age.Equals(39)).FirstOrDefault();
            Console.WriteLine($"{filteredUser.Name} {filteredUser.Age}");
            Users GetDefaultUsers()
            {
                return new Users
                {
                    Name = "Plamen",
                    Age = 39
                };
            }
            Users GetDefaultDumbDumb()
            {
                return new Users
                {
                    Name = "Ivan",
                    Age = 37
                };
            }
            Users GetDefaultBot()
            {
                return new Users
                {
                    Name = "Bot",
                    Age = 34
                };
            }
        }
    }
}
