using SAS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Data.Interfaces
{
    public interface IUser
    {
        bool SaveChanges();

        IEnumerable<User> GetAllUsers();
        User GetUserById(Guid id);
        void CreateNewUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);

    }
}
