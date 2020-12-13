using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlimGym_winversion.DB_Connection
{
    class Queries
    {
        public static string query;

        public static string getUsersOrEmployees(/*string name, string surname, string personalId, string birthDate*/)
        {
            query = "select * from person";
            //query = "select" +
            //    "name, " +
            //    "surname, " +
            //    "birth_date," +
            //    "personal_id, " +
            //    "users.user_id" +
            //    "from person " +
            //    "join users on ";
            return query;
        }

        public static string getLogin(string password, string username)
        {
            query = "select " +
                "name, " +
                "surname, " +
                "account.username, " +
                "account.rights " +
                "from person " +
                "join person_registration on person.personal_id = person_registration.person_id " +
                "join account on person_registration.username = account.username " +
                "where account.username = '" + username + "' and account.password = '" + password + "'";
            return query;
        }
    }
}
