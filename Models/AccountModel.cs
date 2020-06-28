using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class AccountModel
    {

        private OnlineShopDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShopDbContext();
        }

        public bool Login(string UserName ,string PassWord)
        {
            object[] sqlPrams =
            {
                new SqlParameter("@UserName",UserName),
                new SqlParameter("@PassWord",PassWord)

            };

            var res = context.Database.SqlQuery<bool>("Sp_Accout_Login @UserName,@PassWord",sqlPrams).SingleOrDefault();

            return res;
        }






    }
}
