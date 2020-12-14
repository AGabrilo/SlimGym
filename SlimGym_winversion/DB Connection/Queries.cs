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

        public static string getUsers(string name, string surname, string personalId, string birthDate)
        {
            string conditions = createConditionsString(name, surname, personalId, birthDate);

            query = "select " +
                "name, " +
                "surname, " +
                "birth_date, " +
                "personal_id " +
                "user_id " +
                "from users " +
                conditions;
            return query;
        }

        public static string getEmployees(string name, string surname, string personalId, string birthDate)
        {
            string conditions = createConditionsString(name, surname, personalId, birthDate);

            query = "select " +
                "name, " +
                "surname, " +
                "birth_date, " +
                "personal_id " +
                "employee_id " +
                "from employees " +
                conditions;
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

        public static string putUser(string name, string surname, string personalId, string gender, string birtDate, string phonenumber)
        {
            query = "insert into users (name, surname, personal_id, gender, birth_date, phone_number) " +
                "values ('" + name + "', '" + surname + "', '" + personalId + "', '" + gender + "', '" + birtDate + "', " + phonenumber + ")";
            return query;
        }

        public static string putEmployee(string name, string surname, string personalId, string gender, string birtDate, string phonenumber)
        {
            query = "insert into employee (name, surname, personal_id, gender, birth_date, phone_number) " +
                "values ('" + name + "', '" + surname + "', '" + personalId + "', '" + gender + "', '" + birtDate + "', " + phonenumber + ")";
            return query;
        }


        static string createConditionsString(string name, string surname, string personalId, string birthDate)
        {
            string conditions = null;
            if (!string.IsNullOrEmpty(name))
                conditions = "name = '" + name + "'";

            if (!string.IsNullOrEmpty(surname))
            {
                if (!string.IsNullOrEmpty(conditions))
                    conditions += " and";
                conditions += " surname = '" + surname + "'";
            }

            if (!string.IsNullOrEmpty(personalId))
            {
                if (!string.IsNullOrEmpty(conditions))
                    conditions += " and";
                conditions += " personal_id = '" + personalId + "'";
            }

            if (!string.IsNullOrEmpty(birthDate))
            {
                if (!string.IsNullOrEmpty(conditions))
                    conditions += " and";
                conditions += " birth_date = '" + birthDate + "'";
            }

            if (!string.IsNullOrEmpty(conditions))
                conditions = "where " + conditions;

            return conditions;
        }
    }
}
