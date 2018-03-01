using Registration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.BusinessLayer
{
    public interface IUserService
    {
        bool SaveUser(User user);
    }
}
