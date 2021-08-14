using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class LoginDAO
    {
        private DBContextSQL DB;
        public LoginDAO()
        {
            DB = new DBContextSQL();
        }

        public int login(string user, string pass)
        {
            var result = DB.Users.SingleOrDefault(x => x.username.Contains(user) && x.pass.Contains(pass));
            var result2 = DB.Users.Where(x => x.typeUser == "Admin").SingleOrDefault(x => x.username.Contains(user) && x.pass.Contains(pass));
            var result3 = DB.Users.Where(x => x.typeUser == "User").SingleOrDefault(x => x.username.Contains(user) && x.pass.Contains(pass));
            var result4 = DB.Users.Where(x => x.typeUser == "Rescue").SingleOrDefault(x => x.username.Contains(user) && x.pass.Contains(pass));
            if (result == null)
            {
                return 0;
            }
            else if (result2 != null)
            {
                return 1;
            }
            else if (result3 != null)
            {
                return 2;
            }
            else
            { return 3; }
        }
    }
}
