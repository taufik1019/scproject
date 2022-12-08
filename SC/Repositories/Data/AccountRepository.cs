using Microsoft.EntityFrameworkCore;
using SC.Context;
using SC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SC.Repositories.Data
{
    public class AccountRepository
    {
        MyContext myContext;
        public AccountRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public ResponLogin Login(Login login)
        {
            var data = myContext.UserRoles
                .Include(x => x.Role)
                .Include(x => x.User)
                .FirstOrDefault(x => x.User.Email.Equals(login.Email) &&
                                     x.User.Password.Equals(login.Password));
            if(data !=null)
            {
                if (data.Role.Id == 1)
                {
                    var data1 = myContext.UserRoles
                                .Include(x => x.Role)
                                .Include(x => x.User)
                                .Include(x => x.User.Staff)
                                .FirstOrDefault(x => x.User.Email.Equals(login.Email) &&
                                     x.User.Password.Equals(login.Password));
                    if (data1 != null) {
                        var respon = new ResponLogin()
                        {
                            Id = data1.User.Id,
                            IdRole = data1.Role.Id,
                            Name = data1.User.Staff.Name,
                            Role = data1.Role.Name
                        };
                        return respon;
                    }
                }
                else if (data.Role.Id == 2)
                {
                    var data1 = myContext.UserRoles
                               .Include(x => x.Role)
                               .Include(x => x.User)
                               .Include(x => x.User.Mhs)
                               .FirstOrDefault(x => x.User.Email.Equals(login.Email) &&
                                    x.User.Password.Equals(login.Password));
                    if (data1 != null)
                    {
                        var respon = new ResponLogin()
                        {
                            Id = data1.User.Id,
                            IdRole = data1.Role.Id,
                            Name = data1.User.Mhs.Name,
                            Role = data1.Role.Name
                        };
                        return respon;
                    }
                }
            }
            return null;

        }
    }
}
