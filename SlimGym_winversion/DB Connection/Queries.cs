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
                "personal_id, " +
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

        public static string getUserToAddEntrance(string name, string surname, string personalId, string birthDate)
        {
            string conditions = createConditionsString(name, surname, personalId, birthDate);
            if (conditions == null)
                conditions = "where selection.user_id is null";
            else
                conditions += " and selection.user_id is null";
            query = "select " +
                "name, " +
                "surname, " +
                "birth_date, " +
                "personal_id, " +
                "users.user_id " +
                "from users " +
                "left join " +
                "(select " +
                "users.user_id " +
                "from users " +
                "join user_attendance on user_attendance.user_id = users.user_id " +
                "join attendance on attendance.attendance_id = user_attendance.attendance_id " +
                "where attendance.end_time is null) selection on selection.user_id = users.user_id " +
                conditions;
            return query;
        }

        public static string getUserToAddExit(string name, string surname, string personalId, string birthDate)
        {
            string conditions = createConditionsString(name, surname, personalId, birthDate);
            if (conditions == null)
                conditions = "where attendance.end_time is null";
            else
                conditions += " and attendance.end_time is null";
            query = "select " +
                "name, " +
                "surname, " +
                "birth_date, " +
                "personal_id, " +
                "users.user_id " +
                "from users " +
                "join user_attendance on user_attendance.user_id = users.user_id " +
                "join attendance on attendance.attendance_id = user_attendance.attendance_id " +
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
                "values ('" + name + "', '" + surname + "', '" + personalId + "', '" + gender + "', '" + birtDate + "', " + phonenumber + "); " +
                "insert into user_membership (user_id, membership_id) " +
                "SELECT MAX (user_id)" +
                "FROM users";
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


        //get user for user info cs
        public static string getUser(string personalid)
        {
            query = "SELECT " +
                    "name, surname, users.user_id, personal_id, birth_date, gender, phone_number, " +
                    "um.payment_date, um.expiration_date, membership.membership_level " +
                    "from users " +
                    "left join user_membership um on um.user_id = users.user_id " +
                    "left join membership on membership.membership_id = um.membership_id " +
                    "left join " + 
                    "(SELECT " +
                    "MIN( user_membership.payment_date) as p_date " + 
                    "FROM users " +
                    "join user_membership on user_membership.user_id=users.user_id " +
                    ") u_m on u_m.p_date=um.payment_date " +
                    "where users.personal_id = " + personalid;
            return query;
        }

        public static string getPeopleInTheGym()
        {
            query = "select " +
                "name as \"Name\", " +
                "surname as \"Surname\", " +
                "attendance.start_time as \"Entrance Time\", " +
                "users.user_id as \"User ID \" " +
                "from users " +
                "join user_attendance on users.user_id = user_attendance.user_id " +
                "join attendance on attendance.attendance_id = user_attendance.attendance_id " +
                "where attendance.end_time is null";
            return query;
        }
        public static string getRecordsOfUsers(string date)
        {
            query = "select " +
                "name as \"Name\", " +
                "surname as \"Surname\", " +
                "attendance.start_time as \"Entrance Time\", " +
                "attendance.end_time as \"Exit Time\", " +
                "attendance.date as \"Date\", " +
                "users.user_id as \"User ID \" " +
                "from users " +
                "join user_attendance on users.user_id = user_attendance.user_id " +
                "join attendance on attendance.attendance_id = user_attendance.attendance_id " +
                "where attendance.date = '" + date + "'::date";
            return query;
        }

        public static string putRecordEntrance(string user_id)
        {
            query = "insert into attendance (start_time, date) " +
                "values ('" + DateTime.Now.ToString("t") + "', '" + DateTime.Now.ToString("MM/dd/yyyy") + "'); " +
                "insert into user_attendance (user_id, attendance_id) " +
                "select '" + user_id + "', max(attendance_id) from attendance;";
            return query;
        }
        public static string getEntranceInfo(string user_id)
        {
            query = "select " +
                "attendance.start_time " +
                "from user_attendance " +
                "join attendance on attendance.attendance_id = user_attendance.attendance_id " +
                "where attendance.end_time is null and user_attendance.user_id = '" + user_id + "'";
            return query;
        }

        public static string putRecordExit(string user_id)
        {
            query = "update attendance " +
                "set end_time = '" + DateTime.Now.ToString("t") + "'" +
                "where attendance.end_time is null and attendance.attendance_id in (select attendance_id from user_attendance where user_id = " + user_id + ")";
            return query;
        }

        public static string putMembershipRecord(string user_id, string membership_id)
        {
            query = "insert into user_membership (user_id, membership_id, payment_date, expiration_date) " +
                "values(" + user_id + ", " + membership_id + ", '" + DateTime.Now.ToString("MM/dd/yyyy") + "', '" + DateTime.Now.AddMonths(1).ToString("MM/dd/yyyy") + "')";
            return query;
        }

        public static string putGroupRecord(string user_id, string group_id)
        {
            query = "insert into attends (user_id, group_id) " +
                "values(" + user_id + ", " + group_id + ");" +
                "update \"group\" " +
                "set " +
                "members = members + 1, " +
                "max_members = max_members - 1 " +
                "where group_id = " + group_id;
            return query;
        }

    }
}
