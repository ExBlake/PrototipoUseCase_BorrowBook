using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowBook.Clases
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        //llamamos el metodo recoverPassword(recuperar contraseña)
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }
    }
}
