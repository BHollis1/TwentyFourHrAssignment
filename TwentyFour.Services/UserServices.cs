using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFour.Data;
using TwentyFour.Models;

namespace TwentyFour.Services
{
    public class UserServices
    {
        private readonly Guid _userId;

        public UserServices(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateUser (UserCreate model)
        {

            var entity =
                new User()
                {
                    UserId = _userId,
                    Name = model.Name,
                    Email = model.Email,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.User.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<UserListItem> GetUsers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .User
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new UserListItem
                                {
                                    Name = e.Name,
                                    Email = e.Email,
                                }
                        );

                return query.ToArray();
            }
        }
    }
}
