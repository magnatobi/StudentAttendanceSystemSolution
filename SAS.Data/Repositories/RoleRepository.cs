using Microsoft.EntityFrameworkCore;
using SAS.Data.Entities;
using SAS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS.Data.Repositories
{
    public class RoleRepository : IRole
    {
        private readonly DataContext _context;
        public RoleRepository(DataContext context) => _context = context;

        public void AddNewRole(Role role)
        {
            if (role == null) throw new ArgumentNullException(nameof(role));
            _context.Roles.Add(role);
        }

        public void DeleteRole(Role role)
        {
            var record = _context.Roles.FirstOrDefault(r => r.RoleId == role.RoleId);
            if (record != null) _context.Roles.Remove(record);
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _context.Roles.ToList();
        }

        public Role GetRoleById(int roleId)
        {
            return _context.Roles.FirstOrDefault(x => x.RoleId == roleId);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateRole(Role role)
        {
            _context.Entry(role).State = EntityState.Modified;
        }
    }
}
