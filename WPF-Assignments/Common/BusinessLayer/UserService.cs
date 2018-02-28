using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Model;

namespace Common.BusinessLayer
{
    public class UserService: IUserService
    {
        public bool SaveUser(User user)
        {
            try
            {
                using (StreamWriter writetext = new StreamWriter(@"D:/write.txt"))
                {
                    writetext.WriteLine($"Name: {user.Name}");
                    writetext.WriteLine($"Date of Birth: {user.DOB}");
                }
                return true;
            }
            catch (Exception ex)
            {
            }
            return false;
        }
    }
}
