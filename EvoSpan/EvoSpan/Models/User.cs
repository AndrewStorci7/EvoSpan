using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace EvoSpan.Models
{
    /**
     *  Name:
     *      Internal Class User
     * 
     *  Description:
     *      This class is used to save the data of the user accessing the application.
     *      
     *  Since:
     *      2.23.9.10
     *
     */
    internal class User
    {
        // Name and Surname
        protected readonly List<string> name;

        // Generated unique id
        protected readonly string id;

        // Emails
        protected List<string> email;

        // Telephone Number
        protected uint number;

        // Date of Birthday
        protected DateTime birthday;

        // Role
        protected string role;

        // Hourly Wage
        protected double hourly_wage;

        // Hourly Service Cost
        protected double hourly_service_cost;

        // Work Shifts
        protected List<Shifts> shifts;

        public User()
        {
            name = null;
            id = "";
            email = null;
            number = 0;
            birthday = new DateTime(0, 0, 0);
            role = "";
            hourly_wage = 0;
            hourly_service_cost = 0;
            shifts = null;
        }

        public User(List<string> name, List<string> email, DateTime date, string role, double hw, double hsc, List<Shifts> s, List<User> usrs, uint number = 0)
        {
            if (name == null) throw new ArgumentNullException("Name not specified");
            if (email == null) throw new ArgumentNullException("Email not specified");
            if (date == null) throw new ArgumentNullException("Date of Birthday not specified");
            if (role == null) throw new ArgumentNullException("Role not specified");
            if (hw < 0) throw new ArgumentOutOfRangeException("Hourly Wage not valid");
            if (hsc < 0) throw new ArgumentOutOfRangeException("Hourly Service Cost not valid");
            try
            {
                shifts = s;
                id = generateId(name, usrs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            this.name = name;
            this.email = email;
            birthday = date;
            this.role = role;
            hourly_wage = hw;
            hourly_service_cost = hsc;

            if (number == 0)
                this.number = 0;
            else this.number = number;
        }

        /**
          * <summary>
          * <para>
          * Generate an <c>unique id</c> for the class User.
          * It's created with the concatenation of the name and the surname, 
          * if the id is already exists, an additional character (a number) is added 
          * </para>
          * </summary>
          * <param name="name">list containing name and surname</param>
          * <param name="usr">list of users</param>
          * <returns>
          * The unique Id for the User
          * </returns>
          */
        protected string generateId(List<string> name, List<User> usr)
        {
            // Sanitize strings
            for (int i = 0; i < name.Count; i++)
                name[i] = sanitize(name[i]);

            if (name == null || name[0] == "" || name[0] == "undefined") throw new ArgumentNullException("name");
            string id = name[0].ToLower() + "." + name[1].ToLower();
            int check = 0;
            for (int i = 0; i < usr.Count; i++)
            {
                if (usr[i].id == id)
                    check++;
            }
            id += check;
            return id;
        }

        /**
         * <summary>
         * <para>
         * Allows you to sanitize and adjust a string, removing special characters that are not accepted.
         * Used only for <c>internal</c> purpose
         * </para>
         * </summary>
         * <param name="str">string to sanitize</param>
         * <returns>
         * A string sanitized, with illegal characters replaced by <c>'_'</c>. 
         * </returns>
         */
        protected string sanitize(string str)
        {
            string ret = null;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] < 65 || str[i] > 90 || str[i] < 97 || str[i] > 122 || str[i] < 128 || str[i] > 165)
                    ret += "_";
                else
                    ret += str[i];
            }
            return ret;
        }
    }
}
