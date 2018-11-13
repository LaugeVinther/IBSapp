using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BusinessLogic
{
    public class CalibrateLogin : ICalibrateLogin
    {
        string username = "admin"; // OBS! dette skal ændres, når der er oprettet databaser 
        int password = 1234;

        public bool CheckLogin(String username, String pw)
        {
            if (username == "admin" && password == 1234) // OBS! dette skal ændres, når der er oprettet databaser 
            {
                return true;
            }
            else
                return false;
        }
    }
}
