using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class Class1
    {
        public static bool login(string login, string password)
        {
            ModelDataBaseContainer DataBase = new Storage.ModelDataBaseContainer();
            var user = DataBase.Users.FirstOrDefault(x => x.Login == login) ;

            if (user == null)
                return false;
            else
                if(user.Password == password)
                    return true;
                else
                    return false;
        }
    }
}
