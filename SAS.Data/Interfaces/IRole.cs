using SAS.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Data.Interfaces
{
    public interface IRole
    {
        bool SaveChanges();

        IEnumerable<Role> GetAllRoles();
        Role GetRoleById(int roleId);
        void AddNewRole(Role role);
        void DeleteRole(Role role);
        void UpdateRole(Role role);
    }
}
