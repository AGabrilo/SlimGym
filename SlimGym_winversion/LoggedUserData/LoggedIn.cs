using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SlimGym_winversion.LoggedUser
{
    public class LoggedIn
    {
        int rights;
        string username;
        string name;
        string surname;

        public LoggedIn(DataTable dataTable)
        {
            username = dataTable.Rows[0][0].ToString();
            name = dataTable.Rows[0][1].ToString();
            surname = dataTable.Rows[0][2].ToString();
            rights = int.Parse(dataTable.Rows[0][3].ToString());
        }

        public int Rights
        {
            get => rights;
        }
    }
}
